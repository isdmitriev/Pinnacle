using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PinnacleClasses.Dto
{
    public class Sport
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hasOfferings")]
        public bool HasOfferings { get; set; }

        [JsonProperty("leagueSpecialsCount")]
        public long LeagueSpecialsCount { get; set; }

        [JsonProperty("eventSpecialsCount")]
        public long EventSpecialsCount { get; set; }

        [JsonProperty("eventCount")]
        public long EventCount { get; set; }
    }
}
