using System;
using System.Collections.Generic;
using System.Text;
using PinnacleClasses.DatabaseObjects;
using PinnacleClasses.Dto;
using System.Reflection;
using System.Globalization;
namespace PinnacleClasses.Converters
{
  public   interface IPinnaclePricesToDatabaseConverter
    {
        PinacclePrices ConvertPinnacleEventToDatabasePrices(OddEvent oddEvent);
    }
    /// <summary>
    /// Класс для преобразования пинакл события в обьект отображающийся на таблицу в бд
    /// </summary>
   public  class PricesToDatabaseConverter:IPinnaclePricesToDatabaseConverter
    {
        private  IList<PropertyInfo> properties;
        private  PinacclePrices pinaccle;

        private List<decimal?> eventDiscs = null;
        public PricesToDatabaseConverter()
        {
            this.eventDiscs = new List<decimal?>();
            
            //this.properties = pinaccle.GetType().GetProperties();
        }

       

        public PinacclePrices ConvertPinnacleEventToDatabasePrices(OddEvent oddEvent)
        {
            eventDiscs.Clear();
            this.pinaccle = new PinacclePrices();

            

            this.pinaccle.IsLive = oddEvent.IsLive;
            this.pinaccle.DateAdded = oddEvent.DateAdded;

            this.pinaccle.EventId = oddEvent.EventId.ToString();
            this.properties = this.pinaccle.GetType().GetProperties();
            this.pinaccle.HomeTeam = oddEvent.HomeTeam;
            this.pinaccle.AwayTeam = oddEvent.AwayTeam;
            this.pinaccle.StartTime = oddEvent.StartTime;
            OddPeriod oddPeriod = oddEvent.Periods[0];

            MoneyLine moneyLine = oddPeriod.MoneyLine;

            List<Handicap> handicaps = oddPeriod.Handicaps;

            List<Total> totals = oddPeriod.Totals;

            DoubleChance doubleChance = oddPeriod.DoubleChance;

            if (oddPeriod.TeamTotal != null)
            {
                Total homeTotal = oddPeriod.TeamTotal.Home;

                Total awayTeamTotal = oddPeriod.TeamTotal.Away;
                if (homeTotal != null)
                {
                    this.SetHomeTeamTotalPricesTodatabase(homeTotal);
                }

                if (awayTeamTotal != null)
                {
                    this.SetAwayTeamTotalPricesToDatabase(awayTeamTotal);
                }
            }


            this.SetMoneyLinePricesToDatabase(moneyLine);
            //this.SetDoubleChanceToDatabasePrices(doubleChance);

            this.SetTotalPricesToDatabase(totals);

            //this.SetHomeTeamTotalPricesTodatabase(homeTotal);

            //this.SetAwayTeamTotalPricesToDatabase(awayTeamTotal);

            this.SetHandicapPricesToDatabase(handicaps);

            //var result = MathClass.GetStatsForMarket(this.eventDiscs);

            //this.pinaccle.EventDiscMax = result.maxDisc;

            //this.pinaccle.EventDiscAverage = result.averageDisc;

            //this.pinaccle.EventMediana = MathClass.GetMedForMarket(this.eventDiscs);

            return this.pinaccle;
          
        }


        private void SetMoneyLinePricesToDatabase(MoneyLine moneyLine)
        {
            if (moneyLine != null)
            {
                this.pinaccle.HOME = moneyLine.Home;
                this.pinaccle.AWAY = moneyLine.Away;
                this.pinaccle.DRAW = moneyLine.Draw;
                this.pinaccle.HOME_computed_ = moneyLine.HomeComputed;
                this.pinaccle.DRAW_computed_ = moneyLine.DrawCompute;
                this.pinaccle.AWAY_computed_ = moneyLine.AwayComputed;
                this.pinaccle.HOME_disc = moneyLine.HomeDisc;
                this.pinaccle.AWAY_disc = moneyLine.AwayDisc;
                this.pinaccle.DRAW_disc = moneyLine.DrawDisc;

                //List<decimal?> discs = new List<decimal?>();

                //discs.Add(this.pinaccle.HOME_disc);
                //discs.Add(this.pinaccle.AWAY_disc);
                //discs.Add(this.pinaccle.DRAW_disc);
                //var result = MathClass.GetStatsForMarket(discs);

                //this.pinaccle.MoneyLine_disc_max = result.maxDisc;
                //this.pinaccle.MoneyLine_disc_average =decimal.Round((decimal)result.averageDisc,3);
                //this.pinaccle.MoneyLine_disc_mediana = MathClass.GetMedForMarket(discs);

                //this.eventDiscs.Add(moneyLine.HomeDisc);
                //this.eventDiscs.Add(moneyLine.DrawDisc);
                //this.eventDiscs.Add(moneyLine.AwayDisc);
                
            }
        }

        private void SetDoubleChanceToDatabasePrices(DoubleChance doubleChance)
        {
            this.pinaccle.HOMEAWAY = doubleChance.HomeAway;
            this.pinaccle.HOMEDRAW = doubleChance.HomeDraw;
            this.pinaccle.DRAWAWAY = doubleChance.AwayDraw;
            this.pinaccle.HOMEAWAY_computed_ = doubleChance.HomeAwayComputed;
            this.pinaccle.HOMEDRAW_computed_ = doubleChance.HomeDrawComputed;
            this.pinaccle.DRAWAWAY_computed_ = doubleChance.AwayDrawComputed;
            this.pinaccle.HOMEAWAY_disc = doubleChance.HomeAwayDisc;
            this.pinaccle.HOMEDRAW_disc = doubleChance.HomeDrawDisc;
            this.pinaccle.DRAWAWAY_disc = doubleChance.AwayDrawDisc;
        }
        private void SetHandicapPricesToDatabase(List<Handicap> handicaps)
        {
            List<decimal?> hdpDiscs = new List<decimal?>();
            IList<PropertyInfo> propertyInfos = GetPropertiesByPrefix("HOME_HDP", "AWAY_HDP", this.properties);
            for(int i = 0; i < propertyInfos.Count; i++)
            {
                decimal handicap = this.GetHandicapPropertyValue(propertyInfos[i]);

                foreach(Handicap handicapComputed in handicaps)
                {
                    if(propertyInfos[i].Name.Contains("HOME_HDP") &&  handicap == handicapComputed.HDPHOME && propertyInfos[i].Name.Contains("computed")==false && propertyInfos[i].Name.Contains("disc")==false)
                    {
                        propertyInfos[i].SetValue(this.pinaccle, handicapComputed.HOME);
                    }

                    if (propertyInfos[i].Name.Contains("AWAY_HDP") && handicap == handicapComputed.HDPAWAY && propertyInfos[i].Name.Contains("computed") == false && propertyInfos[i].Name.Contains("disc")==false)
                    {
                        propertyInfos[i].SetValue(this.pinaccle, handicapComputed.AWAY);
                    }

                    if (propertyInfos[i].Name.Contains("HOME_HDP") && handicap == handicapComputed.HDPHOME && propertyInfos[i].Name.Contains("computed") ==true)
                    {
                        propertyInfos[i].SetValue(this.pinaccle, handicapComputed.HOMECOMPUTED);
                    }
                    if (propertyInfos[i].Name.Contains("AWAY_HDP") && handicap == handicapComputed.HDPAWAY && propertyInfos[i].Name.Contains("computed") == true)
                    {
                        propertyInfos[i].SetValue(this.pinaccle, handicapComputed.AWAYCOMPUTED);
                    }


                    if (propertyInfos[i].Name.Contains("HOME_HDP") && handicap == handicapComputed.HDPHOME && propertyInfos[i].Name.Contains("disc") ==true)
                    {
                        propertyInfos[i].SetValue(this.pinaccle, handicapComputed.HOMEDISC);
                        //hdpDiscs.Add(handicapComputed.HOMEDISC);

                        //this.eventDiscs.Add(handicapComputed.HOMEDISC);
                    }

                    if (propertyInfos[i].Name.Contains("AWAY_HDP") && handicap == handicapComputed.HDPAWAY && propertyInfos[i].Name.Contains("disc") == true)
                    {
                        propertyInfos[i].SetValue(this.pinaccle, handicapComputed.AWAYDISC);
                        //hdpDiscs.Add(handicapComputed.AWAYDISC);

                        //this.eventDiscs.Add(handicapComputed.AWAYDISC);
                    }


                }

            }

            //var result = MathClass.GetStatsForMarket(hdpDiscs);
            //this.pinaccle.HDP_disc_max = result.maxDisc;
            //this.pinaccle.HDP_disc_average = result.averageDisc;

            //this.pinaccle.HDP_disc_mediana = MathClass.GetMedForMarket(hdpDiscs);
          
        }

        private void SetTotalPricesToDatabase(List<Total> totals)
        {
            List<decimal?> totalDiscs = new List<decimal?>();
            IList<PropertyInfo> propertyInfos = GetPropertiesByPrefix("TO_", "TU_", this.properties);
            for(int i=0;i<propertyInfos.Count;i++)
            {
                decimal points = this.GetTotalPropoertyValue(propertyInfos[i]);
                foreach(Total total in totals)
                {
                    if (points == total.Points)
                    {
                        if(propertyInfos[i].Name.Contains("TO_") && propertyInfos[i].Name.Contains("computed") == false && propertyInfos[i].Name.Contains("disc")==false)
                        {
                            
                            propertyInfos[i].SetValue(this.pinaccle, total.Over);
                        }

                        if (propertyInfos[i].Name.Contains("TU_") && propertyInfos[i].Name.Contains("computed") == false && propertyInfos[i].Name.Contains("disc") == false)
                        {
                            propertyInfos[i].SetValue(this.pinaccle, total.Under);
                        }
                        if (propertyInfos[i].Name.Contains("TO_") && propertyInfos[i].Name.Contains("computed") ==true)
                        {
                            propertyInfos[i].SetValue(this.pinaccle, total.OverComputed);
                        }

                        if (propertyInfos[i].Name.Contains("TU_") && propertyInfos[i].Name.Contains("computed") ==true)
                        {
                            propertyInfos[i].SetValue(this.pinaccle, total.UnderComputed);
                        }

                        if (propertyInfos[i].Name.Contains("TU_") && propertyInfos[i].Name.Contains("disc") == true)
                        {
                            propertyInfos[i].SetValue(this.pinaccle, total.UnderDisc);
                            //totalDiscs.Add(total.UnderDisc);

                            //this.eventDiscs.Add(total.UnderDisc);
                        }

                        if (propertyInfos[i].Name.Contains("TO_") && propertyInfos[i].Name.Contains("disc") == true)
                        {
                            propertyInfos[i].SetValue(this.pinaccle, total.OverDisc);
                            //totalDiscs.Add(total.OverDisc);

                            //this.eventDiscs.Add(total.OverDisc);
                        }



                    }
                }
            }

            //var result = MathClass.GetStatsForMarket(totalDiscs);
            //this.pinaccle.Total_disc_max = result.maxDisc;
            //this.pinaccle.Total_disc_average = result.averageDisc;

            //this.pinaccle.Total_disc_mediana = MathClass.GetMedForMarket(totalDiscs);
            
           
        }

        private void SetHomeTeamTotalPricesTodatabase(Total homeTotal)
        {
            IList<PropertyInfo> propertyInfos = GetPropertiesByPrefix("T1O_", "T1U_", this.properties);
            List<decimal?> teamTotalDiscs = new List<decimal?>();
            for(int i = 0; i < propertyInfos.Count; i++)
            {
                decimal points = this.GetTeamOneTotalValue(propertyInfos[i]);
                
                
                    if (homeTotal.Points == points)
                    {
                        if(propertyInfos[i].Name.Contains("T1O_") && propertyInfos[i].Name.Contains("computed") == false && propertyInfos[i].Name.Contains("disc")==false)
                        {
                            propertyInfos[i].SetValue(this.pinaccle, homeTotal.Over);
                        }

                        if (propertyInfos[i].Name.Contains("T1O_") && propertyInfos[i].Name.Contains("computed") ==true)
                        {
                            propertyInfos[i].SetValue(this.pinaccle, homeTotal.OverComputed);
                        }

                        if (propertyInfos[i].Name.Contains("T1U_") && propertyInfos[i].Name.Contains("computed") ==false && propertyInfos[i].Name.Contains("disc") == false)
                        {
                            propertyInfos[i].SetValue(this.pinaccle, homeTotal.Under);
                        }

                        if (propertyInfos[i].Name.Contains("T1U_") && propertyInfos[i].Name.Contains("computed") == true)
                        {
                            propertyInfos[i].SetValue(this.pinaccle, homeTotal.UnderComputed);
                        }

                    if (propertyInfos[i].Name.Contains("T1U_") && propertyInfos[i].Name.Contains("disc") == true)
                    {
                        propertyInfos[i].SetValue(this.pinaccle, homeTotal.UnderDisc);
                        //teamTotalDiscs.Add(homeTotal.UnderDisc);

                        //this.eventDiscs.Add(homeTotal.UnderDisc);
                    }

                    if (propertyInfos[i].Name.Contains("T1O_") && propertyInfos[i].Name.Contains("disc") == true)
                    {
                        propertyInfos[i].SetValue(this.pinaccle, homeTotal.OverDisc);
                        //teamTotalDiscs.Add(homeTotal.OverDisc);

                        //this.eventDiscs.Add(homeTotal.OverDisc);
                    }




                }


            }

            //var result = MathClass.GetStatsForMarket(teamTotalDiscs);
            //this.pinaccle.T1_disc_max = result.maxDisc;
            //this.pinaccle.T1_disc_average = result.averageDisc;

            //this.pinaccle.T1_disc_mediana = MathClass.GetMedForMarket(teamTotalDiscs);

        }

        private void SetAwayTeamTotalPricesToDatabase(Total awayTotal)
        {
            List<decimal?> awayTotalsDisc = new List<decimal?>();
            IList<PropertyInfo> propertyInfos = GetPropertiesByPrefix("T2O_", "T2U_", this.properties);

            for (int i = 0; i < propertyInfos.Count; i++)
            {

                decimal points = this.GetTeamTwoTotal(propertyInfos[i]);


                if (awayTotal.Points == points)
                {
                    if (propertyInfos[i].Name.Contains("T2O_") && propertyInfos[i].Name.Contains("computed") == false && propertyInfos[i].Name.Contains("disc") == false)
                    {
                        propertyInfos[i].SetValue(this.pinaccle, awayTotal.Over);
                    }

                    if (propertyInfos[i].Name.Contains("T2O_") && propertyInfos[i].Name.Contains("computed") == true)
                    {
                        propertyInfos[i].SetValue(this.pinaccle, awayTotal.OverComputed);
                    }
                    if (propertyInfos[i].Name.Contains("T2O_") && propertyInfos[i].Name.Contains("disc") == true)
                    {
                        propertyInfos[i].SetValue(this.pinaccle, awayTotal.OverDisc);
                        //awayTotalsDisc.Add(awayTotal.OverDisc);

                        //this.eventDiscs.Add(awayTotal.OverDisc);
                    }



                    if (propertyInfos[i].Name.Contains("T2U_") && propertyInfos[i].Name.Contains("computed") == true)
                    {
                        propertyInfos[i].SetValue(this.pinaccle, awayTotal.UnderComputed);
                    }

                    if (propertyInfos[i].Name.Contains("T2U_") && propertyInfos[i].Name.Contains("disc") == true)
                    {
                        propertyInfos[i].SetValue(this.pinaccle, awayTotal.UnderDisc);
                        //awayTotalsDisc.Add(awayTotal.UnderDisc);

                        //this.eventDiscs.Add(awayTotal.UnderDisc);
                    }

                    if (propertyInfos[i].Name.Contains("T2U_") && propertyInfos[i].Name.Contains("disc") == false && propertyInfos[i].Name.Contains("computed") ==false)
                    {
                        propertyInfos[i].SetValue(this.pinaccle, awayTotal.Under);
                        
                    }

                }
            }

            //var result = MathClass.GetStatsForMarket(awayTotalsDisc);
            //this.pinaccle.T2_disc_max = result.maxDisc;
            //this.pinaccle.T2_disc_average = result.averageDisc;

            //this.pinaccle.T2_disc_mediana = MathClass.GetMedForMarket(awayTotalsDisc);
        }
        
        

                
            

       /// <summary>
       /// возвращает массив имен свойств обьекта PinnaclePrices по префиксу
       /// </summary>
       /// <param name="prefix1"></param>
       /// <param name="prefix2"></param>
       /// <param name="propertyInfos"></param>
       /// <returns></returns>
        private static IList<PropertyInfo> GetPropertiesByPrefix(string prefix1,string prefix2, IList<PropertyInfo> propertyInfos)
        {
            IList<PropertyInfo> properties = new List<PropertyInfo>();

            foreach(PropertyInfo info in propertyInfos)
            {
               
                if(info.Name.Contains(prefix1)==true || info.Name.Contains(prefix2) == true)
                {
                    properties.Add(info);
                }
            }

            return properties;
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
        private decimal GetTotalPropoertyValue(PropertyInfo property)
        {
            decimal result = 0.0M;

            string name = property.Name;

            name = name.Replace("TO_", "").Replace("TU_", "").Replace("_computed_", "").Replace("_disc", "").Replace("_", ",");
            
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

