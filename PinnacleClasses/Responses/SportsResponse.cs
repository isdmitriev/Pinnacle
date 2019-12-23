using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using PinnacleClasses.Dto;
namespace PinnacleClasses.Responses
{

    public class SportsResponse
    {
        [JsonProperty("sports")]
        public List<Sport> Sports { get; set; }
    }

}
