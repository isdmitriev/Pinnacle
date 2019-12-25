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
        List<PricesNew> Convert(OlimpOddEvent oddEvent);
    }

    public class OlimpOddEventToPricesConverter : IOlimpOddEventToPricesNewConverter
    {
        public List<PricesNew> Convert(OlimpOddEvent oddEvent)
        {
            List<PricesNew> _resultPrices = new List<PricesNew>();

            return _resultPrices;
        }

        private List<PricesNew> ConvertMoneyLine(OlimpOddEvent olimpOddEvent)
        {
            List<PricesNew> pricesNewsMoneyLine = new List<PricesNew>();

            MarketKindName marketKindName = MarketKindName.ThreeWay;

            IList<PropertyInfo> properties = olimpOddEvent.moneyLine.GetType().GetProperties();
            foreach(PropertyInfo property in properties)
            {
                PricesNew prices = new PricesNew();
                prices.LeagueName = olimpOddEvent.LeagueName;


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

        private List<PricesNew> ConvertDoubleChance(OlimpOddEvent olimpOddEvent)
        {
            List<PricesNew> pricesNewDoubleChance = new List<PricesNew>();

            MarketKindName marketKindName = MarketKindName.DoubleChance;

            IList<PropertyInfo> properties = olimpOddEvent.doubleChance.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                PricesNew prices = new PricesNew();
                prices.LeagueName = olimpOddEvent.LeagueName;


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

        private List<PricesNew> ConvertHandicaps(OlimpOddEvent olimpOddEvent)
        {

            List<PricesNew> result = new List<PricesNew>();

            MarketKindName marketKindName = MarketKindName.Handicap;
            foreach(Handicap handicap in olimpOddEvent.Handicaps)
            {
               

                IList<PropertyInfo> properties = handicap.GetType().GetProperties();

                foreach(PropertyInfo property in properties)
                {
                    PricesNew pricesNew = new PricesNew();
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

        private List<PricesNew> ConvertTotals(OlimpOddEvent olimpOddEvent)
        {
            List<PricesNew> result = new List<PricesNew>();

            MarketKindName marketKindName = MarketKindName.Total;

            foreach(Total total in olimpOddEvent.Totals)
            {
                IList<PropertyInfo> properties = total.GetType().GetProperties();

                foreach(PropertyInfo property in properties)
                {
                    PricesNew pricesNew = new PricesNew();
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

        private List<PricesNew> ConvertHomeTeamTotals(OlimpOddEvent olimpOddEvent)
        {
            List<PricesNew> result = new List<PricesNew>();
            MarketKindName marketKindName = MarketKindName.HomeTeamTotal;

            foreach(Total total in olimpOddEvent.HomeTotals)
            {
                IList<PropertyInfo> properties = total.GetType().GetProperties();

                foreach(PropertyInfo property in properties)
                {
                    PricesNew pricesNew = new PricesNew();
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

        private List<PricesNew> ConvertAwayTeamTotals(OlimpOddEvent olimpOddEvent)
        {
            List<PricesNew> result = new List<PricesNew>();
            MarketKindName marketKindName = MarketKindName.AwayTeamTotal;

            foreach (Total total in olimpOddEvent.AwayTotals)
            {
                IList<PropertyInfo> properties = total.GetType().GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    PricesNew pricesNew = new PricesNew();
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
