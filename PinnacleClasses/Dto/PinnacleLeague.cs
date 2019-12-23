using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using PinnacleClasses.Dto;

namespace PinnacleClasses.Dto
{
    public class PinnacleLeague
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("events")]
        public List<PinnacleEvent> Events { get; set; }

    }
}
