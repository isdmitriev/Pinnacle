using System;
using System.Collections.Generic;
using System.Text;
using Olimp.Dal.Dbcontext;
using Olimp.Converters;
using Olimp.Dto;
using Olimp.Singletons;
using Olimp.Dal;
namespace Olimp
{
    class EventsHandler
    {
        private readonly IOlimpclient _olimpClient = new OlimpClient();
        private readonly IPricesToDatabaseConverter _pricesToDatabaseConverter = new PricesToDatabaseConverter();

        private readonly OlimpPricesContext _pricesContext = new OlimpPricesContext();
        private readonly OlimpFullLinePricesContext _fullLinePricesContext = new OlimpFullLinePricesContext();

        private readonly OlimpDatetimeconverter _datetimeconverter = new OlimpDatetimeconverter();

        public EventsHandler()
        {

        }

        public void SaveOlimpEvents()
        {
            List<OlimpOddEvent> events = this._olimpClient.GetOdds().Result;

            foreach(OlimpOddEvent olimpOdd in events)
            {
                this._fullLinePricesContext.Prices.Add(this._pricesToDatabaseConverter.Convert(olimpOdd));
            }

            this._fullLinePricesContext.SaveChanges();
            this._fullLinePricesContext.Dispose();

            
        }

        public void SaveTodayPrematchOlimpEvents()
        {
            List<OlimpEvent> events = this._olimpClient.GetOlimpEventsParalel().Result;

            List<OlimpEvent> events2 = new List<OlimpEvent>();

            foreach (OlimpEvent olimp in events)
            {
                var result = this._datetimeconverter.GetDateTime(olimp);
                if (result.startTime != null)
                {
                    double discStartTime = result.timeDisc;
                    string eventId = olimp.EventId;

                    if(discStartTime<=120 && discStartTime > 1)
                    {
                        if(discStartTime<90 && EventIdsListSingleton.ContainsEventId(eventId) == false)
                        {
                            continue;
                        }
                        events2.Add(olimp);

                        

                    }
                }
            }

            List<OlimpOddEvent> olimpOddEvents = this._olimpClient.GetTodayPrematchOdds(events2).Result;
            List<OlimpPrices> prices = new List<OlimpPrices>();
            foreach(OlimpOddEvent olimpOdd in olimpOddEvents)
            {
                prices.Add(this._pricesToDatabaseConverter.Convert(olimpOdd));

                EventIdsListSingleton.AddId(olimpOdd.EventId);
            }

            this._pricesContext.Prices.AddRange(prices);
            this._pricesContext.SaveChanges();
            this._pricesContext.Dispose();
        }
    }
}
