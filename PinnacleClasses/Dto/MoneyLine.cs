using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PinnacleClasses.Dto
{
    public class MoneyLine
    {
        [JsonProperty("home")]
        public decimal ? Home { get; set; }

        [JsonProperty("away")]
        public decimal ? Away { get; set; }

        [JsonProperty("draw")]
        public decimal ? Draw { get; set; }

        public decimal ? HomeComputed { get; set; }

        public decimal ? AwayComputed { get; set; }

        public decimal ? DrawCompute { get; set; }

        public decimal? HomeDisc { get; set; }

        public decimal? AwayDisc { get; set; }

        public decimal? DrawDisc { get; set; }

        public decimal? FairHome { get; set; }

        public decimal? FairDraw { get; set; }

        public decimal ?FairAway { get; set; }

    }
}
