using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using PinnacleClasses.Dto;
namespace PinnacleClasses.Responses
{
   public class OddResponse
    {
        [JsonProperty("sportId")]
        public int SportId { get; set; }

        [JsonProperty("last")]
        public long Last { get; set; }

        [JsonProperty("leagues")]
        public List<OddLeague> Leagues { get; set; }
    }
}
