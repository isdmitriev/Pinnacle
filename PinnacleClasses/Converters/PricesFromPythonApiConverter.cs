using System;
using System.Collections.Generic;
using System.Text;
using PinnacleClasses.Dto;
using PinnacleClasses.Responses;
using System.Globalization;
using PinnacleClasses;
namespace PinnacleClasses.Converters
{
    interface IPricesFromPythonApiConverter
    {
        void ConvertPrices(Dictionary<string, decimal> prices, OddEvent oddEvent);
    }
        
    /// <summary>
    /// Класс для установки вычисленных значений на исходы и расхождений для события
    /// 
    /// </summary>
   public class PricesFromPythonApiConverter:IPricesFromPythonApiConverter
    {
        /// <summary>
        /// Метод устанавливает вычисленные на api к-ты для пинакл события
        /// Устанавливает расхождения между вычисленными к-ми и очищенными к-ми для пинакл события
        /// </summary>
        /// <param name="prices">Вычисленные на python api значения к-ов на исходы в виде ключ значение</param>
        /// <param name="oddEvent">Пинакл событие</param>
        public void ConvertPrices(Dictionary<string, decimal> prices, OddEvent oddEvent)
        {

            SetTotalComputedPrices(prices, oddEvent);
            SetMoneyLineComputedPrices(prices, oddEvent);
            SetTotalComputedPricesFirstTeam(prices, oddEvent);
            SetTotalComputedPricesSecondTeam(prices, oddEvent);
            SetComputedHandicapPrices(prices, oddEvent);
            SetComputedDoubleChancePrices(prices, oddEvent);


        }
        /// <summary>
        /// Расхождение между вычисленным и очищенным к-ом на исход события
        /// </summary>
        /// <param name="k1"></param>
        /// <param name="k2"></param>
        /// <returns></returns>
        private static decimal? GetDiscByCoefs(decimal? k1, decimal? k2)
        {
            decimal? result = 0.0M;
            decimal? p1 = 1 / k1;
            decimal? p2 = 1 / k2;
            result = Math.Abs(((decimal)p1 - (decimal)p2));

            return result;
        }

        /// <summary>
        /// Устанавливает вычисленные к-ты и расхождения для события на исходы:1X2
        /// </summary>
        /// <param name="prices"></param>
        /// <param name="oddEvent"></param>
        private static void SetMoneyLineComputedPrices(Dictionary<string, decimal> prices, OddEvent oddEvent)
        {

            MoneyLine moneyLine = oddEvent.Periods[0].MoneyLine;
            if (moneyLine != null)
            {
                decimal? margin = MathClass.GetMargin3(moneyLine.Home, moneyLine.Draw, moneyLine.Away);

                moneyLine.FairHome = (moneyLine.Home / (1 - margin));
                moneyLine.FairDraw = (moneyLine.Draw / (1 - margin));
                moneyLine.FairAway = (moneyLine.Away / (1 - margin));




                if (moneyLine != null)
                {
                    foreach (KeyValuePair<string, decimal> keyValuePair in prices)
                    {
                        decimal? price;
                        if (keyValuePair.Key.Equals("ML 1") == true)
                        {

                            price = keyValuePair.Value;
                            moneyLine.HomeComputed = price;
                            moneyLine.HomeDisc = GetDiscByCoefs(moneyLine.FairHome, moneyLine.HomeComputed);

                        }

                        if (keyValuePair.Key.Equals("ML X") == true)
                        {

                            price = keyValuePair.Value;
                            moneyLine.DrawCompute = price;
                            moneyLine.DrawDisc = GetDiscByCoefs(moneyLine.FairDraw, moneyLine.DrawCompute);

                        }

                        if (keyValuePair.Key.Equals("ML 2") == true)
                        {
                            price = keyValuePair.Value;
                            moneyLine.AwayComputed = price;
                            moneyLine.AwayDisc = GetDiscByCoefs(moneyLine.FairAway, moneyLine.AwayComputed);


                        }


                    }
                }

            }

        }
        /// <summary>
        ///  Устанавливает вычисленные к-ты  для события на исходы:DoubleChance
        /// </summary>
        /// <param name="prices"></param>
        /// <param name="oddEvent"></param>
        private static void SetComputedDoubleChancePrices(Dictionary<string, decimal> prices, OddEvent oddEvent)
        {

            oddEvent.Periods[0].DoubleChance = new DoubleChance();
            foreach (KeyValuePair<string, decimal> keyValuePair in prices)
            {
                decimal price;
                if (keyValuePair.Key.Equals("DC 1X") == true)
                {

                    price = keyValuePair.Value;
                    oddEvent.Periods[0].DoubleChance.HomeDrawComputed = price;
                }

                if (keyValuePair.Key.Equals("DC X2") == true)
                {

                    price = keyValuePair.Value;
                    oddEvent.Periods[0].DoubleChance.AwayDrawComputed = price;
                }

                if (keyValuePair.Key.Equals("DC 12") == true)
                {
                    price = keyValuePair.Value;
                    oddEvent.Periods[0].DoubleChance.HomeAwayComputed = price;
                }


            }

        }

        /// <summary>
        /// Устанавливает вычисленные к-ты и расхождения для события на исходы:Handicap
        /// </summary>
        /// <param name="prices"></param>
        /// <param name="oddEvent"></param>
        private static void SetComputedHandicapPrices(Dictionary<string, decimal> prices, OddEvent oddEvent)
        {
            
            List<Handicap> _pinnacleHandicaps = oddEvent.Periods[0].Handicaps;
            for (int i = 0; i < _pinnacleHandicaps.Count;i++)
            {
                decimal? margin = MathClass.GetMargin2(_pinnacleHandicaps[i].HOME, _pinnacleHandicaps[i].AWAY);
                _pinnacleHandicaps[i].FairHome = _pinnacleHandicaps[i].HOME / (1 - margin);
                _pinnacleHandicaps[i].FairAway = _pinnacleHandicaps[i].AWAY / (1 - margin);
                foreach (KeyValuePair<string, decimal> keyValuePair in prices)
                {
                    decimal resultHome = 0.0M;
                    decimal resultAway = 0.0M;
                    if (keyValuePair.Key.Contains("HDP1 ") == true)
                    {
                        string name = keyValuePair.Key.Replace("HDP1 ", "");
                        resultHome = Decimal.Parse(name, CultureInfo.InvariantCulture);

                        foreach (KeyValuePair<string, decimal> keyValuePair2 in prices)
                        {

                            if (keyValuePair2.Key.Contains("HDP2 ") == true)
                            {
                                string name2 = keyValuePair2.Key.Replace("HDP2 ", "");
                                resultAway = Decimal.Parse(name2, CultureInfo.InvariantCulture);

                                if (resultHome == resultAway * (-1) && _pinnacleHandicaps[i].HDPHOME == resultHome && _pinnacleHandicaps[i].HDPAWAY == resultAway)
                                {

                                    _pinnacleHandicaps[i].HOMECOMPUTED = keyValuePair.Value;
                                    _pinnacleHandicaps[i].AWAYCOMPUTED = keyValuePair2.Value;
                                    _pinnacleHandicaps[i].HOMEDISC = GetDiscByCoefs(_pinnacleHandicaps[i].FairHome, _pinnacleHandicaps[i].HOMECOMPUTED);
                                    _pinnacleHandicaps[i].AWAYDISC = GetDiscByCoefs(_pinnacleHandicaps[i].FairAway,_pinnacleHandicaps[i].AWAYCOMPUTED);

                                }
                            }
                        }

                    }
                }
            }
        }
        /// <summary>
        ///  Устанавливает вычисленные к-ты и расхождения для события на исходы:Total
        /// </summary>
        /// <param name="prices"></param>
        /// <param name="oddEvent"></param>
        private static void SetTotalComputedPrices(Dictionary<string, decimal> prices, OddEvent oddEvent)
        {
            
            List<Total> _pinnacleTotals = oddEvent.Periods[0].Totals;
            for (int i = 0; i < _pinnacleTotals.Count; i++)
            {

                decimal points = _pinnacleTotals[i].Points;

                decimal? margin = MathClass.GetMargin2(_pinnacleTotals[i].Over, _pinnacleTotals[i].Under);
                _pinnacleTotals[i].FairOver = _pinnacleTotals[i].Over /( 1 - margin);
                _pinnacleTotals[i].FairUnder = _pinnacleTotals[i].Under / (1 - margin);
                foreach (KeyValuePair<string, decimal> keyValuePair in prices)
                {
                    if (keyValuePair.Key.StartsWith("T O") == true)
                    {
                        decimal resultOver = 0.0M;
                        decimal resultUnder = 0.0M;
                        string name = keyValuePair.Key.Replace("T O ", "");

                        resultOver = Decimal.Parse(name, CultureInfo.InvariantCulture);


                        foreach (KeyValuePair<string, decimal> keyValuePair2 in prices)
                        {
                            if (keyValuePair2.Key.StartsWith("T U") == true)
                            {
                                string name2 = keyValuePair2.Key.Replace("T U ", "");
                                resultUnder = Decimal.Parse(name2, CultureInfo.InvariantCulture);

                                if (resultOver == resultUnder && resultOver == points)
                                {
                                    _pinnacleTotals[i].OverComputed = keyValuePair.Value;
                                    _pinnacleTotals[i].UnderComputed = keyValuePair2.Value;
                                    _pinnacleTotals[i].OverDisc = GetDiscByCoefs(_pinnacleTotals[i].FairOver, _pinnacleTotals[i].OverComputed);
                                    _pinnacleTotals[i].UnderDisc = GetDiscByCoefs(_pinnacleTotals[i].FairUnder,_pinnacleTotals[i].UnderComputed);

                                  
                                }
                            }
                        }




                    }
                }
            }
        }
        /// <summary>
        ///  Устанавливает вычисленные к-ты и расхождения для события на исходы:TeamTotalOne
        /// </summary>
        /// <param name="prices"></param>
        /// <param name="oddEvent"></param>
        private static void SetTotalComputedPricesFirstTeam(Dictionary<string, decimal> prices, OddEvent oddEvent)
        {


            if (oddEvent.Periods[0].TeamTotal != null && oddEvent.Periods[0].TeamTotal.Home!=null)
            {
                Total _pinnacleFirstTeamTotal = oddEvent.Periods[0].TeamTotal.Home;
                decimal points = _pinnacleFirstTeamTotal.Points;

                decimal? margin = MathClass.GetMargin2(_pinnacleFirstTeamTotal.Over, _pinnacleFirstTeamTotal.Under);
                _pinnacleFirstTeamTotal.FairOver = _pinnacleFirstTeamTotal.Over / (1 - margin);
                _pinnacleFirstTeamTotal.FairUnder = _pinnacleFirstTeamTotal.Under / (1 - margin);
                foreach (KeyValuePair<string, decimal> keyValuePair in prices)
                {
                    decimal resultPointsOver = 0.0M;
                    decimal resultPointsUnder = 0.0M;
                    if (keyValuePair.Key.StartsWith("T1 O") == true)
                    {



                        string name = keyValuePair.Key.Replace("T1 O ", "");
                        resultPointsOver = Decimal.Parse(name, CultureInfo.InvariantCulture);

                        foreach (KeyValuePair<string, decimal> keyValuePair2 in prices)
                        {

                            if (keyValuePair2.Key.Contains("T1 U") == true)
                            {

                                string name2 = keyValuePair2.Key.Replace("T1 U ", "");
                                resultPointsUnder = Decimal.Parse(name2, CultureInfo.InvariantCulture);
                                if (resultPointsOver == resultPointsUnder && resultPointsOver == points)
                                {
                                    _pinnacleFirstTeamTotal.OverComputed = keyValuePair.Value;
                                    _pinnacleFirstTeamTotal.UnderComputed = keyValuePair2.Value;
                                    _pinnacleFirstTeamTotal.OverDisc = GetDiscByCoefs(_pinnacleFirstTeamTotal.FairOver, _pinnacleFirstTeamTotal.OverComputed);
                                    _pinnacleFirstTeamTotal.UnderDisc = GetDiscByCoefs(_pinnacleFirstTeamTotal.FairUnder, _pinnacleFirstTeamTotal.UnderComputed);

                                }
                            }

                        }
                    }
                }
            }


        }
        /// <summary>
        /// Устанавливает вычисленные к-ты и расхождения для события на исходы:TeamTotalTwo
        /// </summary>
        /// <param name="prices"></param>
        /// <param name="oddEvent"></param>
        private static void SetTotalComputedPricesSecondTeam(Dictionary<string, decimal> prices, OddEvent oddEvent)
        {
            if (oddEvent.Periods[0].TeamTotal != null && oddEvent.Periods[0].TeamTotal.Away!=null)
            {

                Total _pinnacleSecondTeamTotal = oddEvent.Periods[0].TeamTotal.Away;
                decimal points = _pinnacleSecondTeamTotal.Points;
                decimal? margin = MathClass.GetMargin2(_pinnacleSecondTeamTotal.Over, _pinnacleSecondTeamTotal.Under);

                _pinnacleSecondTeamTotal.FairOver = _pinnacleSecondTeamTotal.Over / (1 - margin);
                _pinnacleSecondTeamTotal.FairUnder = _pinnacleSecondTeamTotal.Under / (1 - margin);
                foreach (KeyValuePair<string, decimal> keyValuePair in prices)
                {
                    decimal resultPointsOver = 0.0M;
                    decimal resultPointsUnder = 0.0M;
                    if (keyValuePair.Key.StartsWith("T2 O") == true)
                    {



                        string name = keyValuePair.Key.Replace("T2 O ", "");
                        resultPointsOver = Decimal.Parse(name, CultureInfo.InvariantCulture);

                        foreach (KeyValuePair<string, decimal> keyValuePair2 in prices)
                        {

                            if (keyValuePair2.Key.Contains("T2 U") == true)
                            {

                                string name2 = keyValuePair2.Key.Replace("T2 U ", "");
                                resultPointsUnder = Decimal.Parse(name2, CultureInfo.InvariantCulture);
                                if (resultPointsOver == resultPointsUnder && resultPointsOver == points)
                                {
                                    _pinnacleSecondTeamTotal.OverComputed = keyValuePair.Value;
                                    _pinnacleSecondTeamTotal.UnderComputed = keyValuePair2.Value;
                                    _pinnacleSecondTeamTotal.OverDisc = GetDiscByCoefs(_pinnacleSecondTeamTotal.FairOver, _pinnacleSecondTeamTotal.OverComputed);
                                    _pinnacleSecondTeamTotal.UnderDisc = GetDiscByCoefs(_pinnacleSecondTeamTotal.FairUnder, _pinnacleSecondTeamTotal.UnderComputed);
                                }
                            }

                        }
                    }

                }
            }




        }
    }
}

          
            

        



       
    

