using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PinnacleClasses.DatabaseObjects;
using PinnacleClasses.Datacontext;
using Microsoft.AspNetCore.Hosting;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using PinnacleClasses.Converters;
using System.IO;
using System.Data;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
namespace PinnacleWeb.Controllers

{
    public class ExcelController : Controller
    {
        IHostingEnvironment _appEnvironment;
        PinnaclePricesContext context = new PinnaclePricesContext();
        public ExcelController(IHostingEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        public IActionResult Excel()
        {
            return View();





            
        }
    }
}