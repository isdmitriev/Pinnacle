using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Olimp.Dal.NewdatabaseClasses
{
    public enum MarketKindName
    {
        Total,
        Handicap,
        ThreeWay,
        HomeTeamTotal,
        AwayTeamTotal,
        BothTeamToScore,
        DoubleChance
    }

    public enum SelectionKindName
    {
        Home,
        Draw,
        Away,
        Over,
        Under,
        Yes,
        No,
        HomeDraw,
        AwayDraw,
        HomeAway
    }


   public class OlimpPrices
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public DateTime QueueTime { get; set; }
        public string EventName { get; set; }

        public string StartTime { get; set; }
        public string  EventId { get; set; }

        public string LeagueName { get; set; }

        public decimal ? Price { get; set; }
        public decimal ? MarketValue { get; set; }

        public MarketKindName MarketKindName { get; set; }

        public SelectionKindName SelectionKindName { get; set; }






    }
}
