using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace PinnacleClasses.Dto
{
    public class OddPeriod
    {
        [JsonProperty("lineId")]
        public long LineId { get; set; }

        /// <summary>
        ///     This represents the period of the match. For example, for soccer we have 0 (Game), 1 (1st Half) & 2 (2nd Half)
        /// </summary>
        [JsonProperty("number")]
        public int Number { get; set; }

        /// <summary>
        ///     string
        ///     date-time
        ///         Period’s wagering cut-off date in UTC.
        /// </summary>
        [JsonProperty("cutoff")]
        public DateTimeOffset Cutoff { get; set; }

        /// <summary>
        ///     Maximum spread bet. Only in straight odds response.
        /// </summary>
        [JsonProperty("maxSpread")]
        public decimal? MaxSpread { get; set; }

        /// <summary>
        ///     Maximum moneyline bet. Only in straight odds response.
        /// </summary>
        [JsonProperty("maxMoneyline")]
        public decimal? MaxMoneyLine { get; set; }

        /// <summary>
        ///     Maximum total points bet. Only in straight odds response.
        /// </summary>
        [JsonProperty("maxTotal")]
        public decimal? MaxTotal { get; set; }

        /// <summary>
        ///     Maximum team total points bet. Only in straight odds response.
        /// </summary>
        [JsonProperty("maxTeamTotal")]
        public decimal? MaxTeamTotal { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        ///     Container for spread odds.
        /// </summary>
        [JsonProperty("spreads")]
        public List<OddsSpread> Spreads { get; set; }

        /// <summary>
        ///     OddsMoneyline
        /// </summary>
        [JsonProperty("moneyline")]
        public MoneyLine MoneyLine { get; set; }

        /// <summary>
        ///     Container for team total points.
        /// </summary>
        [JsonProperty("totals")]
        public List<Total> Totals { get; set; }

        /// <summary>
        ///     ParlayOddsTeamTotals
        /// </summary>
        [JsonProperty("teamTotal")]
        public TeamTotal TeamTotal { get; set; }

        public DoubleChance  DoubleChance  { get; set; }

        public List<Handicap> Handicaps { get; set; }
    }
}

