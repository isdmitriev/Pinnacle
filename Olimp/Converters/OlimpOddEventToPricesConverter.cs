using System;
using System.Collections.Generic;
using System.Text;
using Olimp.Dal;
using Olimp.Dal.NewdatabaseClasses;
using Olimp.Dto;
using System.Reflection;
namespace Olimp.Converters
{
    public interface IOlimpOddEventToPricesNewConverter
    {
        List<OlimpPrices> Convert(OlimpOddEvent oddEvent);
    }

    public class OlimpOddEventToPricesConverter : IOlimpOddEventToPricesNewConverter
    {
        public List<OlimpPrices> Convert(OlimpOddEvent oddEvent)
        {
            List<OlimpPrices> _resultPrices = new List<OlimpPrices>();


            _resultPrices.AddRange(this.ConvertMoneyLine(oddEvent));
            _resultPrices.AddRange(this.ConvertDoubleChance(oddEvent));
            _resultPrices.AddRange(this.ConvertTotals(oddEvent));
            _resultPrices.AddRange(this.ConvertHandicaps(oddEvent));
            _resultPrices.AddRange(this.ConvertHomeTeamTotals(oddEvent));
            _resultPrices.AddRange(this.ConvertAwayTeamTotals(oddEvent));

            foreach(OlimpPrices pricesNew in _resultPrices)
            {
                this.SetPricesParameters(oddEvent,pricesNew);
            }

            return _resultPrices;
        }

        private string GetEventName(string homeTeam,string awayTeam)
        {
            return homeTeam + " - " + awayTeam;
        }

        private void SetPricesParameters(OlimpOddEvent olimpOddEvent,OlimpPrices prices)
        {
            prices.EventId = olimpOddEvent.EventId;
            prices.StartTime = olimpOddEvent.StartDate;
            prices.LeagueName = olimpOddEvent.LeagueName;
            prices.EventName = this.GetEventName(olimpOddEvent.HomeTeam, olimpOddEvent.AwayTeam);
            prices.QueueTime = olimpOddEvent.DateAdded;
        }
        private List<OlimpPrices> ConvertMoneyLine(OlimpOddEvent olimpOddEvent)
        {
            List<OlimpPrices> pricesNewsMoneyLine = new List<OlimpPrices>();

            MarketKindName marketKindName = MarketKindName.ThreeWay;

            IList<PropertyInfo> properties = olimpOddEvent.moneyLine.GetType().GetProperties();
            foreach(PropertyInfo property in properties)
            {
                OlimpPrices prices = new OlimpPrices();
               


                prices.MarketKindName = marketKindName;
                if (property.Name == "Home")
                {
                    
                    prices.SelectionKindName = SelectionKindName.Home;
                    prices.Price = olimpOddEvent.moneyLine.Home;
                }
                else if (property.Name == "Draw")
                {
                    prices.SelectionKindName = SelectionKindName.Draw;
                    prices.Price = olimpOddEvent.moneyLine.Draw;
                }

                else
                {
                    prices.SelectionKindName = SelectionKindName.Away;
                    prices.Price = olimpOddEvent.moneyLine.Away;
                }

                pricesNewsMoneyLine.Add(prices);

            }
            return pricesNewsMoneyLine;
        }

        private List<OlimpPrices> ConvertDoubleChance(OlimpOddEvent olimpOddEvent)
        {
            List<OlimpPrices> pricesNewDoubleChance = new List<OlimpPrices>();

            MarketKindName marketKindName = MarketKindName.DoubleChance;

            IList<PropertyInfo> properties = olimpOddEvent.doubleChance.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                OlimpPrices prices = new OlimpPrices();
                


                prices.MarketKindName = marketKindName;
                if (property.Name == "HomeDraw")
                {

                    prices.SelectionKindName = SelectionKindName.HomeDraw;
                    prices.Price = olimpOddEvent.doubleChance.HomeDraw;
                }
                else if (property.Name == "AwayDraw")
                {
                    prices.SelectionKindName = SelectionKindName.AwayDraw;
                    prices.Price = olimpOddEvent.doubleChance.AwayDraw;
                }

                else
                {
                    prices.SelectionKindName = SelectionKindName.HomeAway;
                    prices.Price = olimpOddEvent.doubleChance.HomeAway;
                }

                pricesNewDoubleChance.Add(prices);

            }
            return pricesNewDoubleChance;
        }

        private List<OlimpPrices> ConvertHandicaps(OlimpOddEvent olimpOddEvent)
        {

            List<OlimpPrices> result = new List<OlimpPrices>();

            MarketKindName marketKindName = MarketKindName.Handicap;
            foreach(Handicap handicap in olimpOddEvent.Handicaps)
            {
               

                IList<PropertyInfo> properties = handicap.GetType().GetProperties();

                foreach(PropertyInfo property in properties)
                {
                    OlimpPrices pricesNew = new OlimpPrices();
                    if(property.Name== "HDPHOME")
                    {
                        pricesNew.MarketKindName = marketKindName;
                        pricesNew.MarketValue= (decimal)property.GetValue(handicap);
                        pricesNew.SelectionKindName = SelectionKindName.Home;
                        pricesNew.Price = handicap.HOME;

                        result.Add(pricesNew);
                    }
                    else if(property.Name== "HDPAWAY")
                    {
                        pricesNew.MarketKindName = marketKindName;
                        pricesNew.MarketValue =(decimal) property.GetValue(handicap);
                        pricesNew.SelectionKindName = SelectionKindName.Away;
                        pricesNew.Price = handicap.AWAY;

                        result.Add(pricesNew);
                    }
                }
            }

            return result;

            
        }

        private List<OlimpPrices> ConvertTotals(OlimpOddEvent olimpOddEvent)
        {
            List<OlimpPrices> result = new List<OlimpPrices>();

            MarketKindName marketKindName = MarketKindName.Total;

            foreach(Total total in olimpOddEvent.Totals)
            {
                IList<PropertyInfo> properties = total.GetType().GetProperties();

                foreach(PropertyInfo property in properties)
                {
                    OlimpPrices pricesNew = new OlimpPrices();
                    pricesNew.MarketKindName = marketKindName;
                    if (property.Name == "Over")
                    {
                        pricesNew.SelectionKindName = SelectionKindName.Over;
                        pricesNew.MarketValue = total.Points;
                        pricesNew.Price = total.Over;

                        result.Add(pricesNew);
                    }

                    else if (property.Name == "Under")
                    {
                        pricesNew.SelectionKindName = SelectionKindName.Under;
                        pricesNew.MarketValue = total.Points;
                        pricesNew.Price = total.Under;
                        result.Add(pricesNew);
                    }
                }
            }

            return result;
        }

        private List<OlimpPrices> ConvertHomeTeamTotals(OlimpOddEvent olimpOddEvent)
        {
            List<OlimpPrices> result = new List<OlimpPrices>();
            MarketKindName marketKindName = MarketKindName.HomeTeamTotal;

            foreach(Total total in olimpOddEvent.HomeTotals)
            {
                IList<PropertyInfo> properties = total.GetType().GetProperties();

                foreach(PropertyInfo property in properties)
                {
                    OlimpPrices pricesNew = new OlimpPrices();
                    pricesNew.MarketKindName = marketKindName;

                    if (property.Name == "Over")
                    {
                        pricesNew.SelectionKindName = SelectionKindName.Over;
                        pricesNew.Price = total.Over;
                        pricesNew.MarketValue = total.Points;

                        result.Add(pricesNew);
                    }

                    else if (property.Name == "Under")
                    {
                        pricesNew.SelectionKindName = SelectionKindName.Under;
                        pricesNew.Price = total.Under;
                        pricesNew.MarketValue = total.Points;

                        result.Add(pricesNew);
                    }
                }
            }

            return result;

        }

        private List<OlimpPrices> ConvertAwayTeamTotals(OlimpOddEvent olimpOddEvent)
        {
            List<OlimpPrices> result = new List<OlimpPrices>();
            MarketKindName marketKindName = MarketKindName.AwayTeamTotal;

            foreach (Total total in olimpOddEvent.AwayTotals)
            {
                IList<PropertyInfo> properties = total.GetType().GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    OlimpPrices pricesNew = new OlimpPrices();
                    pricesNew.MarketKindName = marketKindName;

                    if (property.Name == "Over")
                    {
                        pricesNew.SelectionKindName = SelectionKindName.Over;
                        pricesNew.Price = total.Over;
                        pricesNew.MarketValue = total.Points;

                        result.Add(pricesNew);
                    }

                    else if (property.Name == "Under")
                    {
                        pricesNew.SelectionKindName = SelectionKindName.Under;
                        pricesNew.Price = total.Under;
                        pricesNew.MarketValue = total.Points;

                        result.Add(pricesNew);
                    }
                }
            }

            return result;

        }


    }


}
