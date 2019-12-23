using System;
using System.Collections.Generic;
using System.Text;

namespace PinnacleClasses.Dto
{
   public class DoubleChance
    {
        
        public decimal ? HomeDraw { get; set; }

        
        public decimal ? AwayDraw { get; set; }

        
        public decimal ?HomeAway { get; set; }

        public decimal ? HomeDrawComputed { get; set; }


        public decimal ? AwayDrawComputed { get; set; }


        public decimal ?HomeAwayComputed { get; set; }

        public decimal? HomeDrawDisc { get; set; }


        public decimal? AwayDrawDisc { get; set; }


        public decimal? HomeAwayDisc { get; set; }

    }
}
