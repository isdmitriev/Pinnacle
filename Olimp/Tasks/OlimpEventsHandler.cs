using System;
using System.Collections.Generic;
using System.Text;
using Olimp.Dal;
using Olimp.Converters;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;
namespace Olimp.Tasks
{
    interface IOlimpEventsHandler
    {
        void SavePrematchFootballEventsToDatabase();
    }
    class OlimpEventsHandler : IOlimpEventsHandler
    {
        private readonly EventsHandler _olimpEventsHandler = new EventsHandler();
        private readonly object locker = new object();
        public void SavePrematchFootballEventsToDatabase()
        {
            lock (locker)
            { 

                this._olimpEventsHandler.SaveOlimpEvents();
            }
        }

        public void SaveTodayPrematchOlimpEventsToDatabase()
        {
            lock (locker)
            {

                this._olimpEventsHandler.SaveTodayPrematchOlimpEvents();
            }
        }
    }



    [DisallowConcurrentExecution]
    public class GetPrematchOlimpEventsJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {

            OlimpEventsHandler _olimpEventsHandler = new OlimpEventsHandler();
            _olimpEventsHandler.SavePrematchFootballEventsToDatabase();
            return Task.CompletedTask;
        }
        public GetPrematchOlimpEventsJob()
        {

        }
    }
    [DisallowConcurrentExecution]
    public class GetPrematchTodayOlimpEventsJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {

            OlimpEventsHandler _olimpEventsHandler = new OlimpEventsHandler();
            _olimpEventsHandler.SaveTodayPrematchOlimpEventsToDatabase();
            return Task.CompletedTask;
        }
        public GetPrematchTodayOlimpEventsJob()
        {

        }




    }


    public class OlimpEventsSheduler
    {
        private IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler().Result;

        private IJobDetail jobPrematch = JobBuilder.Create<GetPrematchOlimpEventsJob>().Build();

        private IJobDetail jobDetailTodayPrematch = JobBuilder.Create<GetPrematchTodayOlimpEventsJob>().Build();

        private bool isJobPrematchRunning = false;

        private bool isTodayPrematchJobStart = false;

        private ITrigger trigger = TriggerBuilder.Create()
                            .WithIdentity("trigger1", "group1")
                            .StartNow().WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever()).Build();


        private ITrigger trigger2 = TriggerBuilder.Create()
                          .WithIdentity("trigger1", "group2")
                          .StartNow().WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever()).Build();

        public OlimpEventsSheduler()
        {
            var task = this.scheduler.Start();
            task.Wait();
        }

        public async Task StartAsync()
        {




            if (this.isJobPrematchRunning == false)
            {

                await this.scheduler.ScheduleJob(this.jobPrematch, this.trigger);
                this.isJobPrematchRunning = true;
            }

        }

        public async Task StoptAsync()
        {




            if (this.isJobPrematchRunning ==true)
            {

                await this.scheduler.UnscheduleJob(this.trigger.Key);
                this.isJobPrematchRunning =false;
            }

        }


        public async Task StartTodayPrematchAsync()
        {
            if (this.isTodayPrematchJobStart == false)
            {
                await this.scheduler.ScheduleJob(this.jobDetailTodayPrematch, this.trigger2);
                this.isTodayPrematchJobStart = true;
            }

        }

        public async Task StopTodayPrematchAsync()
        {
            if (this.isTodayPrematchJobStart == true)
            {
                await this.scheduler.UnscheduleJob(this.trigger2.Key);
                this.isTodayPrematchJobStart = false;
            }
        }



    }
}
