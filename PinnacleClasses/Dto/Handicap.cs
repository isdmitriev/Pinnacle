using System;
using System.Collections.Generic;
using System.Text;

namespace PinnacleClasses.Dto
{
   public class Handicap
    {
      public  decimal HDPHOME { get; set; }

      public  decimal HDPAWAY { get; set; }

      public  decimal? HOME { get; set; }

      public  decimal? AWAY { get; set; }

      public  decimal? HOMECOMPUTED { get; set; }

      public  decimal? AWAYCOMPUTED { get; set; }

     public decimal? HOMEDISC{ get; set; }

     public decimal ?AWAYDISC { get; set; }
        public decimal ? FairHome { get; set; }
        public decimal? FairAway { get; set; }




    }
}
