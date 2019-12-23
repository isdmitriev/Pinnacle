using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace PinnacleClasses.Dto
{
   public class OddEvent
    {
        [JsonProperty("id")]
        public long EventId { get; set; }

        public DateTime ? StartTime { get; set; }

        public DateTime? DateAdded { get; set; }
        public bool? IsLive { get; set; }

        public string  HomeTeam { get; set; }

        public string AwayTeam { get; set; }
        [JsonProperty("periods")]
        public List<OddPeriod> Periods { get; set; }

        /// <summary>
        /// Away team score. Only for live soccer events.
        /// </summary>
        [JsonProperty("awayScore")]
        public decimal? AwayScore { get; set; }

        /// <summary>
        /// Home team score. Only for live soccer events.
        /// </summary>
        [JsonProperty("homeScore")]
        public decimal? HomeScore { get; set; }

        /// <summary>
        /// Away team red cards. Only for live soccer events.
        /// </summary>
        [JsonProperty("awayRedCards")]
        public int? AwayRedCards { get; set; }

        /// <summary>
        /// Home team red cards. Only for live soccer events
        /// </summary>
        [JsonProperty("homeRedCards")]
        public int? HomeRedCards { get; set; }
    }
}
