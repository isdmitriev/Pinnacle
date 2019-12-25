using System;
using System.Collections.Generic;
using System.Text;
using Olimp.Dal.Dbcontext;
using Olimp.Converters;
using Olimp.Dto;
using Olimp.Singletons;
using Olimp.Dal;
using Olimp.Dal.Repositories;
using Olimp.Dal.NewdatabaseClasses;
namespace Olimp
{
    class EventsHandler
    {
        private readonly IOlimpclient _olimpClient = new OlimpClient();


        private readonly IOlimpPricesRepository _olimpPricesRepository = new OlimpPricesRepository();

        private readonly IOlimpFullLinePricesRepository _olimpFullLinePricesRepository = new OlimpFullLinePricesRepository();
        private readonly IOlimpOddEventToPricesNewConverter _olimpOddEventToPricesConverter=new OlimpOddEventToPricesConverter();
        
        

        private readonly OlimpDatetimeconverter _datetimeconverter = new OlimpDatetimeconverter();

        public EventsHandler()
        {

        }

        public void SaveOlimpEvents()
        {
            List<OlimpOddEvent> events = this._olimpClient.GetOdds().Result;
            List<OlimpPrices> resultPrices = new List<OlimpPrices>();
            foreach(OlimpOddEvent olimpOdd in events)
            {
                resultPrices.AddRange(this._olimpOddEventToPricesConverter.Convert(olimpOdd));
            }

            this._olimpFullLinePricesRepository.AddRange(resultPrices);

          

            
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
                prices.AddRange(this._olimpOddEventToPricesConverter.Convert(olimpOdd));

                EventIdsListSingleton.AddId(olimpOdd.EventId);
            }

            this._olimpPricesRepository.AddRange(prices);

          
           
        }
    }
}
