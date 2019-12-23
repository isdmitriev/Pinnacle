using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using PinnacleClasses.Dto;
namespace PinnacleClasses.Dto
{
   public class PinnacleEvent
    {
        [JsonProperty("id")]
      
        public long Id { get; set; }

        [JsonProperty("starts")]
       
        public DateTime Starts { get; set; }

        [JsonProperty("home")]
       
        public string Home { get; set; }

        [JsonProperty("away")]
       
        public string Away { get; set; }

        [JsonProperty("rotNum")]
        
        public string RotNum { get; set; }

        [JsonProperty("liveStatus")]
        
        
        public FixtureEventLiveStatus LiveStatus { get; set; }

        [JsonProperty("status")]
       
        public string Status { get; set; }

        [JsonProperty("parlayRestriction")]
      
        public ParlayRestrictionState ParlayRestriction { get; set; }

        [JsonProperty("altTeaser")]
        
        public bool AltTeaser { get; set; }

        [JsonProperty("parentId")]
        
        public long? ParentId { get; set; }

        [JsonProperty("resultingUnit")]
        
        public string ResultingUnit { get; set; }

       

       
    }

    public enum ParlayRestrictionState
    {
        // 0 = Allowed to parlay, without restrictions, 
        AllowParlayNoRestriction = 0,
        //1 = Not allowed to parlay this event, 
        NotAllowedParleyEvent = 1,
        //2 = Allowed to parlay with the restrictions. 
        AllowParlayWithRestriction = 2
    }

    public enum FixtureEventLiveStatus
    {
        //0 = No live betting will be offered on this event
        NoLiveBettingWillBeOffered = 0,
        //1 = Live betting event
        LiveBettingEvent = 1,
        //2 = Live betting will be offered on this event
        LiveBettingWillBeOffered = 2
    }

}
