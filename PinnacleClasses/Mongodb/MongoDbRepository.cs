using System;
using System.Collections.Generic;
using System.Text;
using PinnacleClasses.Dto;
using MongoDB.Driver;
using MongoDB.Bson;
namespace PinnacleClasses.Mongodb
{
   public class PinTotal
    {
        public string Points { get; set; }

        
        public string Over { get; set; }

        
        public string Under { get; set; }
    }

    public class PinHdp
    {
        public string Hdp { get; set; }

        
        public string Home { get; set; }

        
        public string Away { get; set; }
    }


    public class PinData
    {
        public DateTime ? DateAdded { get; set; }
        public string HomeTeam { get; set; }

        public string AwayTeam { get; set; }
        public long EventId { get; set; }

        public decimal ? HomeScore { get; set; }

        public decimal ? AwayScore { get; set; }

        public DateTime? StartTime { get; set; }

        public string Home { get; set; }

        public string Draw { get; set; }

        public string Away { get; set; }

        public List<PinTotal> Totals { get; set; }

        public List<PinHdp> HandiCaps { get; set; }
    }




        public interface IMongoDbRepository
        {
            void Add(PinData data);
            void AddList(List<PinData> data);

            IEnumerable<PinData> GetAll();

            void AddEvent(OddEvent oddEvent);

            void AddEventsList(List<OddEvent> oddEvents);
        }


    
   public class MongoDbRepository:IMongoDbRepository
    {


        private readonly string connectionString = "mongodb://localhost:27017";

        private readonly MongoClient client;
        private readonly IMongoDatabase database;

        private readonly IMongoCollection<PinData> Data;
        public MongoDbRepository()
        {
            client = new MongoClient(this.connectionString);
            database = client.GetDatabase("PinnacleDatabase");
            Data = database.GetCollection<PinData>("Live_Last");
        }

        public void Add(PinData data)
        {
            this.Data.InsertOne(data);
        }

        public void AddList(List<PinData> data)
        {
            this.Data.InsertMany(data);
        }

        public IEnumerable<PinData> GetAll()
        {
            var builder = new FilterDefinitionBuilder<PinData>();
            var filter = builder.Empty;
            return this.Data.Find(filter).ToList();
        }

        public void AddEvent(OddEvent oddEvent)
        {
            PinData pinData = this.ConvertOddEventToPinData(oddEvent);
            this.Add(pinData);
        }

        public void AddEventsList(List<OddEvent> oddEvents)
        {
            foreach(OddEvent oddEvent in oddEvents)
            {
                PinData pinData = this.ConvertOddEventToPinData(oddEvent);

                this.Add(pinData);
            }
        }
        private PinData ConvertOddEventToPinData(OddEvent oddEvent)
        {
            OddPeriod oddPeriod = oddEvent.Periods[0];
            PinData data = new PinData();

            data.DateAdded = DateTime.Now.AddHours(2);

            data.HomeScore = oddEvent.HomeScore;
            data.AwayScore = oddEvent.AwayScore;

            data.Totals = new List<PinTotal>();
            data.HandiCaps = new List<PinHdp>();

            data.EventId = oddEvent.EventId;
            data.StartTime = oddEvent.StartTime;
            data.HomeTeam = oddEvent.HomeTeam;
            data.AwayTeam = oddEvent.AwayTeam;
            if (oddPeriod.MoneyLine != null)
            {
                data.Home = oddPeriod.MoneyLine.Home.ToString();
                data.Away = oddPeriod.MoneyLine.Away.ToString();
                data.Draw = oddPeriod.MoneyLine.Draw.ToString();
            }

            if (oddPeriod.Totals != null && oddPeriod.Totals.Count > 0)
            {
                foreach (Total total in oddPeriod.Totals)
                {
                    data.Totals.Add(new PinTotal() { Points = total.Points.ToString(), Over = total.Over.ToString(), Under = total.Under.ToString() });
                }
            }

            if (oddPeriod.Spreads != null && oddPeriod.Spreads.Count > 0)
            {

                foreach (OddsSpread spread in oddPeriod.Spreads)
                {
                    data.HandiCaps.Add(new PinHdp() { Hdp = spread.Hdp.ToString(), Home = spread.Home.ToString(), Away = spread.Away.ToString() });
                }
            }

            return data;
             
           
        }
    }
}
