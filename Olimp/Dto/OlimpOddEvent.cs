using System;
using System.Collections.Generic;
using System.Text;

namespace Olimp.Dto
{
  public  class OlimpOddEvent
    {

        public string EventId { get; set; }
        public DateTime DateAdded { get; set; }

        public string StartDate { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string LeagueName { get; set; }

        public MoneyLine moneyLine { get; set; }

        public DoubleChance doubleChance { get; set; }

        public List<Total> Totals { get; set; }

       public List<Handicap> Handicaps { get; set; }
       public List<Total> HomeTotals { get; set; }


       public List<Total> AwayTotals { get; set; }
    }
}
