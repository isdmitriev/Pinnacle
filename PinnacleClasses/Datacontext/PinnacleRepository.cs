using System;
using System.Collections.Generic;
using System.Text;
using PinnacleClasses.DatabaseObjects;
using System.Linq;
namespace PinnacleClasses.Datacontext
{
  public  interface IPinnacleRepository
    {
        void AddRange(List<PinacclePrices> pinacclePrices);
        List<PinacclePrices> GetAll();
        void Add(PinacclePrices pinacclePrices);
    }

   public class PinnacleRepository : IPinnacleRepository
    {
        private readonly PinnaclePricesContext _context = new PinnaclePricesContext();

        public PinnacleRepository()
        {
            
        }

        public void Add(PinacclePrices pinacclePrices)
        {
            throw new NotImplementedException();
        }

        public void AddRange(List<PinacclePrices> pinacclePrices)
        {
            this._context.Prices.AddRange(pinacclePrices);
            this._context.SaveChanges();
            
        }

        public List<PinacclePrices> GetAll()
        {
           return this._context.Prices.ToList();
        }

        private void SaveChanges()
        {
            this._context.SaveChanges();
        }
    }
}
