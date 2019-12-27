using System;
using System.Collections.Generic;
using System.Text;
using Olimp.Dal.Dbcontext;
using Olimp.Dal.NewdatabaseClasses;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Olimp.Dal.Repositories
{
    public interface IOlimpPricesRepository
    {
        void Add(OlimpPrices pricesNew);
        void AddRange(List<OlimpPrices> prices);

        List<OlimpPrices> GetAll();
        Task<List<OlimpPrices>> GetAllAsync();

        Task  AddRangeAsync();
        Task AddAsync(OlimpPrices pricesNew);

        void Delete(OlimpPrices pricesNew);

        void Dispose();
        

    }

    public interface IOlimpFullLinePricesRepository
    {
        void Add(OlimpPrices pricesNew);
        void AddRange(List<OlimpPrices> prices);

        List<OlimpPrices> GetAll();
        Task<List<OlimpPrices>> GetAllAsync();

        Task AddRangeAsync(List<OlimpPrices> prices);
        Task AddAsync(OlimpPrices pricesNew);

        void Delete(OlimpPrices pricesNew);

        void Dispose();


    }

    public class OlimpPricesRepository:IOlimpPricesRepository
    {
        private readonly OlimpPricesContext _pricesContext = new OlimpPricesContext();

        public void Add(OlimpPrices pricesNew)
        {
            this._pricesContext.Add(pricesNew);
            this._pricesContext.SaveChanges();
        }

        public async  Task AddRangeAsync()
        {
           await this._pricesContext.Prices.AddRangeAsync();
           await this._pricesContext.SaveChangesAsync();

        }

        public void AddRange(List<OlimpPrices> prices)
        {
            
            foreach(OlimpPrices olimpPrices in prices)
            {
                this._pricesContext.Add(olimpPrices);
                this._pricesContext.SaveChanges();
            }
            
            

            
        }

        public List<OlimpPrices> GetAll()
        {
            return this._pricesContext.Prices.ToList();
        }

        public async  Task<List<OlimpPrices>> GetAllAsync()
        {
            List<OlimpPrices> result =this._pricesContext.Prices.ToList();
            return result;
        }

        public async  Task AddAsync(OlimpPrices pricesNew)
        {
            await this._pricesContext.Prices.AddAsync(pricesNew);
            await this._pricesContext.SaveChangesAsync();
        }

        public void Delete(OlimpPrices pricesNew)
        {
            OlimpPrices pricesNew2 = this._pricesContext.Prices.Find(pricesNew.Id);
            this._pricesContext.Prices.Remove(pricesNew2);
            this._pricesContext.SaveChanges();
        }

        public void Dispose()
        {
            this._pricesContext.Dispose();
        }
    }




    public class OlimpFullLinePricesRepository : IOlimpFullLinePricesRepository
    {
        private readonly OlimpPricesFullLineContext _fullLineContext = new OlimpPricesFullLineContext();
        public void Add(OlimpPrices pricesNew)
        {
            this._fullLineContext.Prices.Add(pricesNew);
            this._fullLineContext.SaveChanges();
        }

        public async  Task AddAsync(OlimpPrices pricesNew)
        {
            await this._fullLineContext.Prices.AddRangeAsync();
            await this._fullLineContext.SaveChangesAsync();
        }

        public void AddRange(List<OlimpPrices> prices)
        {
            foreach(OlimpPrices pricestwo in prices)
            {
                this._fullLineContext.Prices.Add(pricestwo);
                this._fullLineContext.SaveChanges();
            }
            
          
        }

        public async Task AddRangeAsync(List<OlimpPrices> prices)
        {
            await this._fullLineContext.Prices.AddRangeAsync(prices);
            await this._fullLineContext.SaveChangesAsync();
        }

        public void Delete(OlimpPrices pricesNew)
        {
            OlimpPrices prices = this._fullLineContext.Prices.Find(pricesNew.Id);
            this._fullLineContext.Remove(prices);
            this._fullLineContext.SaveChanges();
        }

        public List<OlimpPrices> GetAll()
        {
            return this._fullLineContext.Prices.ToList();
        }

        public async  Task<List<OlimpPrices>> GetAllAsync()
        {
            List<OlimpPrices> result = this._fullLineContext.Prices.ToList();
            return result;
        }

        public void Dispose()
        {
            this._fullLineContext.Dispose();
        }
    }
}
