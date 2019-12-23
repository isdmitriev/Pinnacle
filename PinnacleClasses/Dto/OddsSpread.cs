using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace PinnacleClasses.Dto
{
    public class OddsSpread
    {
        [JsonProperty("hdp")]
        public decimal Hdp { get; set; }

        [JsonProperty("home")]
        public decimal Home { get; set; }

        [JsonProperty("away")]
        public decimal Away { get; set; }

        [JsonProperty("altLineId")]
        public long? AltLineId { get; set; }

        public decimal? HomeComputed { get; set; }

        public decimal? AwayComputed { get; set; }
    }
}
