using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace PinnacleClasses.Dto
{
    public class TeamTotal
    {
        [JsonProperty("home")]
        public Total Home { get; set; }

        [JsonProperty("away")]
        public Total Away { get; set; }
    }
}
