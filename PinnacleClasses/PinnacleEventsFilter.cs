using System;
using System.Collections.Generic;
using System.Text;
using PinnacleClasses.Responses;
using PinnacleClasses.Dto;
using PinnacleClasses;
using System.Threading.Tasks;
using System.Threading;
namespace PinnacleClasses
{
    /// <summary>
    /// Класс для считывания событий по футболу
    /// </summary>
    public class PinnacleEventsFilter
    {
        private readonly PinnacleClient pinnacleClient = new PinnacleClient();


        private List<PinnacleEvent> _events = new List<PinnacleEvent>();
        public PinnacleEventsFilter()
        {

            this.InitilizeEvents();

        }
        /// <summary>
        /// Загрузга данных о событиях по футболу с пинакл
        /// </summary>
        public void InitilizeEvents()
        {
            FixturesResponse response = this.pinnacleClient.GetFixturesAsync().Result;
            foreach (PinnacleLeague league in response.Leagues)
            {
                foreach (PinnacleEvent pinnacleEvent in league.Events)
                {
                    
                    this._events.Add(pinnacleEvent);
                }
            }
        }
        /// <summary>
        /// Устанавливает для события hometeam,awayteam,starttime,islive
        /// </summary>
        /// <param name="oddEvent"></param>
        public void SetOddEventParams(OddEvent oddEvent)
        {
            foreach (PinnacleEvent pinnacleEvent in this._events)
            {
                if (oddEvent.EventId == pinnacleEvent.Id)
                {
                    oddEvent.StartTime = pinnacleEvent.Starts.AddHours(2);
                    oddEvent.HomeTeam = pinnacleEvent.Home;
                    oddEvent.AwayTeam = pinnacleEvent.Away;
                    oddEvent.DateAdded = DateTime.Now;
                    if (pinnacleEvent.LiveStatus == FixtureEventLiveStatus.LiveBettingEvent)
                    {
                        oddEvent.IsLive = true;
                    }
                    else
                    {
                        oddEvent.IsLive = false;
                    }
                    
                }
            }
        }
        /// <summary>
        /// метод возвращает набор событий с пинакл api по футболу(prematch,live) имеющие хотя-бы один половинчатый тотал и гандикап для fulltime
        /// </summary>
        /// <returns></returns>
        public async Task<List<OddEvent>> LoadIntrestingEventsFromPinnacleAsync(bool isLive)
        {
            List<OddEvent> _intrestingEvents = new List<OddEvent>();

            OddResponse oddResponse = await this.pinnacleClient.GetOddsBySportIdAsync("29",isLive);
            


            foreach (OddLeague league in oddResponse.Leagues)
            {
                List<OddEvent> events = league.Events;

                if (events.Count != 0 && events != null)
                {

                    foreach (OddEvent oddEvent in events)
                    {
                        this.SetOddEventParams(oddEvent);

                        if (this.IsEventIntresting2(oddEvent) == true)
                        {
                            this.SetHandicapsForEvent(oddEvent);
                            _intrestingEvents.Add(oddEvent);
                        }

                    }
                }
            }


            

            return _intrestingEvents;
        }





        /// <summary>
        /// Метод определяющий имеет ли пинакл событие  хотя-бы один половинчатый тотал и гандикап для fulltime
        /// </summary>
        /// <param name="oddEvent">пинакл событие</param>
        /// <returns></returns>
        private bool IsEventIntresting2(OddEvent oddEvent)
        {
            bool consistTotal = false;
            bool consistHandicap = false;
            OddPeriod oddPeriod = oddEvent.Periods[0];
            List<Total> totals = oddPeriod.Totals;
            List<OddsSpread> spreads = oddPeriod.Spreads;

            if (totals == null || spreads == null || totals.Count==0 || spreads.Count==0)
            {
                return false;
            }
            foreach (Total total in totals)
            {
                if (total.Points % 1 == 0.5M && total.Points <= 6.5M && total.Points >= 0.5M)
                {
                    consistTotal = true;
                }
            }

            foreach (OddsSpread spread in spreads)
            {
                if (Math.Abs(spread.Hdp % 1 )== 0.5M && spread.Hdp <= 3.5M && spread.Hdp >= -3.5M)
                {
                    consistHandicap = true;
                }
            }
            if (consistTotal == true && consistHandicap == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Инициализирует имеющиеся гандикапы для события
        /// </summary>
        /// <param name="oddEvent"></param>
        private void SetHandicapsForEvent(OddEvent oddEvent)
        {
            OddPeriod oddPeriod = oddEvent.Periods[0];
            List<OddsSpread> spreads = oddPeriod.Spreads;
            oddPeriod.Handicaps = new List<Handicap>();


            foreach (OddsSpread spread in spreads)
            {
                if (spread.Hdp <= 3.5M && spread.Hdp >= -3.5M)
                {
                    Handicap handicap = new Handicap() { HDPHOME = spread.Hdp, HDPAWAY = spread.Hdp * (-1), HOME = spread.Home, AWAY = spread.Away };

                    oddPeriod.Handicaps.Add(handicap);
                }
            }
        }
    }
}
           
        

     

      

      

      
    

