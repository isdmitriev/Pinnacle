using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace PinnacleClasses.Dto
{
    public class Total
    {
        [JsonProperty("points")]
        public decimal Points { get; set; }

        [JsonProperty("over")]
        public decimal Over { get; set; }

        [JsonProperty("under")]
        public decimal Under { get; set; }

        [JsonProperty("altLineId")]
        public long? AltLineId { get; set; }

        public decimal ? OverComputed { get; set; }

        public decimal ? UnderComputed { get; set; }
        public decimal? OverDisc { get; set; }
        public decimal? UnderDisc { get; set; }

        public decimal? FairOver { get; set; }
        public decimal? FairUnder { get; set; }
    }
}
