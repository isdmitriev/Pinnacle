using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace PinnacleClasses.Dto
{
   public class OddLeague
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("events")]
        public List<OddEvent> Events { get; set; }
    }
}
