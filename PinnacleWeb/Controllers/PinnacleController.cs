using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PinnacleClasses.DatabaseObjects;
using PinnacleClasses.Datacontext;
using System.Threading;
using Microsoft.EntityFrameworkCore;
namespace PinnacleWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PinnacleController : ControllerBase
    {
        private readonly PinnaclePricesContext _context = new PinnaclePricesContext();


        [Produces("application/json")]
        public async Task<List<PinacclePrices>> Get()
        {
            return await this._context.Prices.ToListAsync();

        }

    }
}