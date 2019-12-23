using System;
using System.Collections.Generic;
using System.Text;
using PinnacleClasses.Dto;
using System.Linq;

namespace PinnacleClasses
{
   public class MathClass
    {/// <summary>
    /// Вычисление по событию пинакл к-ов для api
    /// </summary>
    /// <param name="oddEvent"></param>
    /// <returns></returns>
        public  static (decimal k1, decimal to, decimal tu, decimal k2, decimal hdp1, decimal hdp2) GetCoefsToPythonApi(OddEvent oddEvent)
        {
            decimal k1 = 0.0M;

            decimal to = 0.0M;

            decimal tu = 0.0M;

            decimal k2 = 0.0M;

            decimal hdp1 = 0.0M;

            decimal hdp2 = 0.0M;





            foreach (Total total in oddEvent.Periods[0].Totals)
            {
                if (total.Points % 1 == 0.5M && total.Points >= 0.5M && total.Points <= 6.5M)
                {
                    k1 = total.Points;
                    to = total.Over;
                    tu = total.Under;
                }
            }

            foreach (OddsSpread spread in oddEvent.Periods[0].Spreads)
            {
                if (Math.Abs(spread.Hdp % 1) == 0.5M && spread.Hdp <= 3.5M && spread.Hdp >= -3.5M)
                {
                    k2 = spread.Hdp;
                    hdp1 = spread.Home;
                    hdp2 = spread.Away;


                }
            }





            return (k1, to, tu, k2, hdp1, hdp2);

        }


        public static decimal? GetMargin2(decimal ?dA,decimal? dB)
        {
            decimal ? margin = 1 - (dA * dB) / (dA + dB);
            return margin;
        }
        public static decimal? GetMargin3(decimal? dA, decimal? dB,decimal? dC)
        {
            decimal? margin = (1 / dA + 1 / dB + 1 / dC - 1) / (1 / dA + 1 / dB + 1 / dC);
            return margin;
        }
     
        public static decimal GetProbability(decimal dFair)
        {
            return 1 / dFair;
        }

        public static(decimal ? maxDisc,decimal ? averageDisc) GetStatsForMarket(List<decimal ?> discList)
        {
            decimal? maxDisc = discList.Max();
            decimal? averageDisc = discList.Average();
            
            

            return ((decimal.Round((decimal)maxDisc,7)), decimal.Round((decimal)averageDisc,7));
        }

        public static decimal? GetMedForMarket(List<decimal?> discs)
        {
            decimal? result = 0.0M;
            discs = discs.OrderBy(x => x).ToList();
            
            if (discs.Count % 2 == 0)
            {
                int count = discs.Count();
                int fIndex = (count / 2)-(1);
                int lIndex = fIndex + 1;

                result = (discs[fIndex] + discs[lIndex])/(2);
            }
            else
            {
                int count = discs.Count();
                int elIndex = count / 2;
                result = discs[elIndex];
              
            }

            return result;

        }

    }
}
