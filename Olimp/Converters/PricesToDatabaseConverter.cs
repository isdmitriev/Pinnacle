using System;
using System.Collections.Generic;
using System.Text;
using Olimp.Dal;
using Olimp.Dto;
using System.Reflection;
using Olimp.Dal.Dbcontext;
namespace Olimp.Converters
{
    public interface IPricesToDatabaseConverter
    {
        OlimpPrices Convert(OlimpOddEvent olimpOddEvent);
    }
    public class PricesToDatabaseConverter : IPricesToDatabaseConverter
    {
        private IList<PropertyInfo> properties;
        private OlimpPrices olimpPrices;

       
        public OlimpPrices Convert(OlimpOddEvent olimpOddEvent)
        {
            this.olimpPrices = new OlimpPrices();

            this.olimpPrices.IsLive = false;

            this.olimpPrices.DateAdded = olimpOddEvent.DateAdded;
            this.properties = this.olimpPrices.GetType().GetProperties();

            if (olimpOddEvent.moneyLine != null)
            {
                this.olimpPrices.HOME = olimpOddEvent.moneyLine.Home;
                this.olimpPrices.DRAW = olimpOddEvent.moneyLine.Draw;
                this.olimpPrices.AWAY = olimpOddEvent.moneyLine.Away;
            }

            if (olimpOddEvent.doubleChance != null)
            {
                this.olimpPrices.HOMEDRAW = olimpOddEvent.doubleChance.HomeDraw;
                this.olimpPrices.HOMEAWAY = olimpOddEvent.doubleChance.HomeAway;
                this.olimpPrices.DRAWAWAY = olimpOddEvent.doubleChance.AwayDraw;
            }

            this.olimpPrices.EventId = olimpOddEvent.EventId;
            this.olimpPrices.HomeTeam = olimpOddEvent.HomeTeam;
            this.olimpPrices.AwayTeam = olimpOddEvent.AwayTeam;
            this.olimpPrices.LeagueName = olimpOddEvent.LeagueName;
            this.olimpPrices.StartTime = olimpOddEvent.StartDate;

            if (olimpOddEvent.Totals != null)
            {
                this.SetTotalPricesToDatabase(olimpOddEvent.Totals);
            }

            if (olimpOddEvent.Handicaps != null)
            {
                this.SetHandicapPricesToDatabase(olimpOddEvent.Handicaps);
            }

            if (olimpOddEvent.HomeTotals != null)
            {
                this.SetHomeTeamTotalPricesTodatabase(olimpOddEvent.HomeTotals);
            }


            if (olimpOddEvent.AwayTotals != null)
            {

                this.SetAwayTeamTotalPricesToDatabase(olimpOddEvent.AwayTotals);
            }


            return this.olimpPrices;
        }

        private void SetTotalPricesToDatabase(List<Total> totals)
        {
            List<decimal?> totalDiscs = new List<decimal?>();
            IList<PropertyInfo> propertyInfos = GetPropertiesByPrefix("TO_", "TU_", this.properties);
            for (int i = 0; i < propertyInfos.Count; i++)
            {
                decimal points = this.GetTotalPropoertyValue(propertyInfos[i]);
                foreach (Total total in totals)
                {
                    if (points == total.Points)
                    {
                        if (propertyInfos[i].Name.Contains("TO_") && propertyInfos[i].Name.Contains("computed") == false && propertyInfos[i].Name.Contains("disc") == false)
                        {

                            propertyInfos[i].SetValue(this.olimpPrices, total.Over);
                        }

                        if (propertyInfos[i].Name.Contains("TU_") && propertyInfos[i].Name.Contains("computed") == false && propertyInfos[i].Name.Contains("disc") == false)
                        {
                            propertyInfos[i].SetValue(this.olimpPrices, total.Under);
                        }




                    }
                }
            }
        }

        private void SetHandicapPricesToDatabase(List<Handicap> handicaps)
        {
            List<decimal?> hdpDiscs = new List<decimal?>();
            IList<PropertyInfo> propertyInfos = GetPropertiesByPrefix("HOME_HDP", "AWAY_HDP", this.properties);
            for (int i = 0; i < propertyInfos.Count; i++)
            {
                decimal handicap = this.GetHandicapPropertyValue(propertyInfos[i]);

                foreach (Handicap handicapComputed in handicaps)
                {
                    if (propertyInfos[i].Name.Contains("HOME_HDP") && handicap == handicapComputed.HDPHOME && propertyInfos[i].Name.Contains("computed") == false && propertyInfos[i].Name.Contains("disc") == false)
                    {
                        propertyInfos[i].SetValue(this.olimpPrices, handicapComputed.HOME);
                    }

                    if (propertyInfos[i].Name.Contains("AWAY_HDP") && handicap == handicapComputed.HDPAWAY && propertyInfos[i].Name.Contains("computed") == false && propertyInfos[i].Name.Contains("disc") == false)
                    {
                        propertyInfos[i].SetValue(this.olimpPrices, handicapComputed.AWAY);
                    }




                }
            }
        }

        private void SetHomeTeamTotalPricesTodatabase(List<Total> homeTotals)
        {
            IList<PropertyInfo> propertyInfos = GetPropertiesByPrefix("T1O_", "T1U_", this.properties);
            List<decimal?> teamTotalDiscs = new List<decimal?>();
            for (int i = 0; i < propertyInfos.Count; i++)
            {
                decimal points = this.GetTeamOneTotalValue(propertyInfos[i]);

                foreach (Total homeTotal in homeTotals)
                {

                    if (homeTotal.Points == points)
                    {
                        if (propertyInfos[i].Name.Contains("T1O_") && propertyInfos[i].Name.Contains("computed") == false && propertyInfos[i].Name.Contains("disc") == false)
                        {
                            propertyInfos[i].SetValue(this.olimpPrices, homeTotal.Over);
                        }



                        if (propertyInfos[i].Name.Contains("T1U_") && propertyInfos[i].Name.Contains("computed") == false && propertyInfos[i].Name.Contains("disc") == false)
                        {
                            propertyInfos[i].SetValue(this.olimpPrices, homeTotal.Under);
                        }






                    }
                }
            }
        }

        private void SetAwayTeamTotalPricesToDatabase(List<Total> awayTotals)
        {
            List<decimal?> awayTotalsDisc = new List<decimal?>();
            IList<PropertyInfo> propertyInfos = GetPropertiesByPrefix("T2O_", "T2U_", this.properties);

            for (int i = 0; i < propertyInfos.Count; i++)
            {

                decimal points = this.GetTeamTwoTotal(propertyInfos[i]);

                foreach (Total awayTotal in awayTotals)
                {
                    if (awayTotal.Points == points)
                    {
                        if (propertyInfos[i].Name.Contains("T2O_") && propertyInfos[i].Name.Contains("computed") == false && propertyInfos[i].Name.Contains("disc") == false)
                        {
                            propertyInfos[i].SetValue(this.olimpPrices, awayTotal.Over);
                        }


                        if (propertyInfos[i].Name.Contains("T2U_") && propertyInfos[i].Name.Contains("disc") == false && propertyInfos[i].Name.Contains("computed") == false)
                        {
                            propertyInfos[i].SetValue(this.olimpPrices, awayTotal.Under);

                        }

                    }
                }
            }

           
        }

        private static IList<PropertyInfo> GetPropertiesByPrefix(string prefix1, string prefix2, IList<PropertyInfo> propertyInfos)
        {
            IList<PropertyInfo> properties = new List<PropertyInfo>();

            foreach (PropertyInfo info in propertyInfos)
            {

                if (info.Name.Contains(prefix1) == true || info.Name.Contains(prefix2) == true)
                {
                    properties.Add(info);
                }
            }

            return properties;
        }

        private decimal GetTotalPropoertyValue(PropertyInfo property)
        {
            decimal result = 0.0M;

            string name = property.Name;

            name = name.Replace("TO_", "").Replace("TU_", "").Replace("_computed_", "").Replace("_disc", "").Replace("_", ",");

            result = Decimal.Parse(name);



            return result;
        }

        private decimal GetTeamOneTotalValue(PropertyInfo property)
        {
            decimal result = 0.0M;
            string name = property.Name;




            name = name.Replace("T1O_", "").Replace("T1U_", "").Replace("_computed_", "").Replace("_disc", "").Replace("_", ",");

            result = Decimal.Parse(name);


            return result;






        }
        private decimal GetTeamTwoTotal(PropertyInfo property)
        {
            decimal result = 0.0M;
            string name = property.Name;




            name = name.Replace("T2O_", "").Replace("T2U_", "").Replace("_computed_", "").Replace("_disc", "").Replace("_", ",");

            result = Decimal.Parse(name);


            return result;

        }

        private decimal GetHandicapPropertyValue(PropertyInfo property)
        {
            decimal result = 0.0M;
            string name = property.Name;
            name = name.Replace("HOME_HDP_", "").Replace("AWAY_HDP_", "").Replace("_computed", "").Replace("_disc", "");
            if (name.StartsWith("_") == true)
            {

                name = "-" + name.Remove(0, 1);
                name = name.Replace("_", ",");

            }
            else
            {
                name = name.Replace("_", ",");
            }

            result = Decimal.Parse(name);

            return result;
        }
    }
}





            


        

    

