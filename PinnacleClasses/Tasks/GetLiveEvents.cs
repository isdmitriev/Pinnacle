using System;
using System.Collections.Generic;
using System.Text;
using Quartz;
using System.Threading.Tasks;
using Quartz.Impl;
using PinnacleClasses;
using PinnacleClasses.Dto;
using PinnacleClasses.Responses;
using PinnacleClasses.PythonClients;
using PinnacleClasses.Converters;
using PinnacleClasses.DatabaseObjects;
using PinnacleClasses.Datacontext;
using System.Linq;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;
using PinnacleClasses.Tasks.Singletons;
using Microsoft.EntityFrameworkCore.Storage;
using PinnacleClasses.Mongodb;

namespace PinnacleClasses.Tasks

{


    interface IPinnacleEventsHandler
    {
        void SetPinnaclePricesToDatabase(int eventsCount, bool isLive);
        void SetComputedPrematchPinnaclePricesToDatabase();
        void SetComputedLivePinnaclePricesToDatabase();

    }


    public class EventsHandler : IPinnacleEventsHandler
    {
        PinnacleEventsFilter _pinnacleEventsFilter = new PinnacleEventsFilter();
        PythonClient _pythonClient = new PythonClient();
        IPinnaclePricesToDatabaseConverter _pricesToDatabaseConverter = new PricesToDatabaseConverter();
        private readonly PinnaclePricesContext _context;
        private readonly PricesFromPythonApiConverter _pricesFromPythonApiConverter = new PricesFromPythonApiConverter();

        private readonly IMongoDbRepository _mongoDbRepository = new MongoDbRepository();
        private readonly object locker = new object();

        public EventsHandler()
        {

            this._context = new PinnaclePricesContext();
        }


        /// <summary>
        /// считывает  события с пинакл, записывает в бд
        /// </summary>
        public void SetPinnaclePricesToDatabase(int eventsCount, bool isLive)
        {
            List<PinacclePrices> convertedPrices = new List<PinacclePrices>();
            List<OddEvent> _intrestingEvents = this._pinnacleEventsFilter.LoadIntrestingEventsFromPinnacleAsync(isLive).Result;

            int i = 0;
            foreach (OddEvent oddEvent in _intrestingEvents)
            {
                convertedPrices.Add(this._pricesToDatabaseConverter.ConvertPinnacleEventToDatabasePrices(oddEvent));
                i++;

                if (i == eventsCount)
                {
                    break;
                }
            }

            this._context.Prices.AddRange(convertedPrices);
            this._context.SaveChanges();

            this._context.Dispose();
        }

 
        public void SetComputedLivePinnaclePricesToDatabase()
        {


            

            List<PinacclePrices> convertedPrices = new List<PinacclePrices>();
                var task = this._pinnacleEventsFilter.LoadIntrestingEventsFromPinnacleAsync(true);
                task.Wait();
                List<OddEvent> _intrestingEvents = task.Result;

            foreach (OddEvent oddEvent in _intrestingEvents)
            {
                double totalMinutes = this.DiscStartTimeLive(oddEvent);
                string eventId = oddEvent.EventId.ToString();



                Dictionary<string, decimal> computedPricesDict = this.GetCoefsFromApi(oddEvent);

                if (computedPricesDict != null)
                {


                    this._pricesFromPythonApiConverter.ConvertPrices(computedPricesDict, oddEvent);
                    convertedPrices.Add(this._pricesToDatabaseConverter.ConvertPinnacleEventToDatabasePrices(oddEvent));



                    this._mongoDbRepository.AddEvent(oddEvent);
                    EventLiveIdsListSinglton.AddId(eventId);



                }
            }


            this._context.Prices.AddRange(convertedPrices);
            this._context.SaveChanges();


            this._context.Dispose();



        }

        /// <summary>
        /// считывает  события с пинакл,рассчитывает к-ты и расхождения для событий, записывает в бд
        /// </summary>
        /// 
        /// <returns></returns>
        public void SetComputedPrematchPinnaclePricesToDatabase()
        {

            lock (locker)
            {
                Console.WriteLine(EventIdsListSinglton.GetInstance().Count);

                List<PinacclePrices> convertedPrices = new List<PinacclePrices>();

                var task = this._pinnacleEventsFilter.LoadIntrestingEventsFromPinnacleAsync(false);
                task.Wait();
                List<OddEvent> _intrestingEvents = task.Result;



                this.SortByStartTime(_intrestingEvents);



                foreach (OddEvent oddEvent in _intrestingEvents)
                {

                    double totalMinutes = this.DiscStartTime(oddEvent);

                    string eventId = oddEvent.EventId.ToString();



                    if ((totalMinutes <=120 && totalMinutes > 1) && oddEvent.IsLive == false)
                    {


                        if (totalMinutes < 90 && EventIdsListSinglton.ContainsEventId(eventId) == false)
                        {
                            continue;
                        }

                        Dictionary<string, decimal> computedPricesDict = this.GetCoefsFromApi(oddEvent);

                        if (computedPricesDict != null)
                        {

                            this._pricesFromPythonApiConverter.ConvertPrices(computedPricesDict, oddEvent);
                            convertedPrices.Add(this._pricesToDatabaseConverter.ConvertPinnacleEventToDatabasePrices(oddEvent));
                            this._mongoDbRepository.AddEvent(oddEvent);
                            EventIdsListSinglton.AddId(eventId);



                        }
                    }

                }

                this._context.Prices.AddRange(convertedPrices);
                this._context.SaveChanges();
                
                this._context.Dispose();

                

                

            }
        }

            
        /// <summary>
        /// Возвращает рассчитанные к-ты с питон api для события
        /// </summary>
        /// <param name="oddEvent"></param>
        /// <returns></returns>
        private Dictionary<string, decimal> GetCoefsFromApi(OddEvent oddEvent)
        {
            var paramsToPythonApi = MathClass.GetCoefsToPythonApi(oddEvent);
            Dictionary<string, decimal> dict = _pythonClient.GetDataFromPythonApi(paramsToPythonApi.k1, paramsToPythonApi.to, paramsToPythonApi.tu, paramsToPythonApi.k2, paramsToPythonApi.hdp1, paramsToPythonApi.hdp2);
            return dict;
        }

        private Dictionary<string, decimal> GetCoefsFromApi2(OddEvent oddEvent)
        {
            var paramsToPythonApi = MathClass.GetCoefsToPythonApi(oddEvent);

            var task = this._pythonClient.GetDataFromPythonApiAsync2(paramsToPythonApi.k1, paramsToPythonApi.to, paramsToPythonApi.tu, paramsToPythonApi.k2, paramsToPythonApi.hdp1, paramsToPythonApi.hdp2);
            task.Wait();

            Dictionary<string, decimal> dict = task.Result;
            return dict;
        }


        private void SortByStartTime(List<OddEvent> events)
        {
            events.Sort((ev1, ev2) => DateTime.Compare((DateTime)ev1.StartTime, (DateTime)ev2.StartTime));

        }



        private double DiscStartTime(OddEvent oddEvent)
        {
            TimeSpan timeSpan = (DateTime)oddEvent.StartTime - (DateTime)DateTime.Now;
            return timeSpan.TotalMinutes;

        }
        private double DiscStartTimeLive(OddEvent oddEvent)
        {
            TimeSpan timeSpan = (DateTime)DateTime.Now - (DateTime)oddEvent.StartTime;
            return timeSpan.TotalMinutes;
        }

        private bool IsEventstartTimeIntresting(double minutes, OddEvent oddEvent)
        {
            double disc = this.DiscStartTime(oddEvent);
            if (disc <= minutes && disc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
    [DisallowConcurrentExecution]
    public class GetPrematchEvents : IJob
    {
        public GetPrematchEvents()
        {

        }

        public Task Execute(IJobExecutionContext context)
        {



            EventsHandler handler = new EventsHandler();
            handler.SetComputedPrematchPinnaclePricesToDatabase();

            return Task.CompletedTask;
        }
    }

    [DisallowConcurrentExecution]
    public class GetLiveEvents : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            EventsHandler handler = new EventsHandler();
            handler.SetComputedLivePinnaclePricesToDatabase();
            return Task.CompletedTask;
        }
    }


    public class PinnacleEventsSheduler
    {
        private IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler().Result;

        private IJobDetail jobPrematch = JobBuilder.Create<GetPrematchEvents>().Build();

        private IJobDetail jobLive = JobBuilder.Create<GetLiveEvents>().Build();

        private ITrigger trigger = TriggerBuilder.Create()
                            .WithIdentity("trigger1", "group1")
                            .StartNow().WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever()).Build();


        private ITrigger trigger2 = TriggerBuilder.Create()
                           .WithIdentity("trigger1", "group2")
                           .StartNow().WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever()).Build();

        private bool isPrematchRuning = false;

        private bool isLiveRunning = false;
        public PinnacleEventsSheduler()
        {

            var task = this.scheduler.Start();
            task.Wait();

        }
        public async Task StartAsync()
        {




            if (this.isPrematchRuning == false)
            {

                await this.scheduler.ScheduleJob(this.jobPrematch, this.trigger);
                this.isPrematchRuning = true;
            }

        }

        public async Task StartAsyncLive()
        {
            if (isLiveRunning == false)
            {
                await this.scheduler.ScheduleJob(this.jobLive, this.trigger2);
                this.isLiveRunning = true;
            }
        }

        public async Task<bool> StopLiveAsync()
        {


            await this.scheduler.UnscheduleJob(this.trigger2.Key);
            isLiveRunning = false;

            return true;
        }

        public async Task<bool> StopAsync()
        {

            await this.scheduler.UnscheduleJob(this.trigger.Key);
            this.isPrematchRuning = false;

            return true;
        }
    }
}




            

        

    



