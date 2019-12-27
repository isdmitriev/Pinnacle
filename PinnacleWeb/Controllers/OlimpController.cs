using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Olimp.Tasks;
using Olimp.Singletons;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using Olimp.Dal.Dbcontext;
using Olimp.Converters;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using OfficeOpenXml;
using System.Net.Http.Headers;
namespace PinnacleWeb.Controllers
{
    public class OlimpController : Controller
    {
        private readonly OlimpEventsSheduler _olimpEventsSheduler = OlimpEventsShedulerSingleton.GetInstance();
        private readonly OlimpPricesContext _olimpPricesContext = new OlimpPricesContext();
        private readonly OlimpPricesFullLineContext olimpPricesFullLineContext = new OlimpPricesFullLineContext();
        IHostingEnvironment _appEnvironment;

        public OlimpController(IHostingEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StartTodayPrematch()
        {
            var task = this._olimpEventsSheduler.StartTodayPrematchAsync();
            task.Wait();
           return RedirectToAction("StartView");
        }

        public IActionResult StartView()
        {
            return View();
        }

        public IActionResult StopTodayPrematch()
        {
            var task = this._olimpEventsSheduler.StopTodayPrematchAsync();
            task.Wait();
            return RedirectToAction("StopView");
        }

        public IActionResult StopView()
        {
            return View();
        }

        public IActionResult StartPrematch()
        {
            var task = this._olimpEventsSheduler.StartAsync();
            task.Wait();
            return RedirectToAction("StartAllView");
        }

        public IActionResult StartAllView()
        {
            return View();
        }

        public IActionResult StopAllPrematch()
        {
            var task = this._olimpEventsSheduler.StoptAsync();
            task.Wait();
            return RedirectToAction("StopAllView");
        }

        public IActionResult StopAllView()
        {
            return View();
        }

        public IActionResult Excel()
        {
            DataTable dataTable = PricesToDataTableConverter.ConvertOlimpPricesTodataTable(this._olimpPricesContext.Prices.ToList());


            string fullName = "/" + string.Format("{0:yyyy-MM-dd_hh-mm-ss-fff}", DateTime.Now) + "data.xlsx";
            FileInfo file = new FileInfo(this._appEnvironment.WebRootPath + fullName);
            ExcelPackage excel = new ExcelPackage(file);
            var ws = excel.Workbook.Worksheets.Add("WriteTest");
            ws.Cells.LoadFromDataTable(dataTable, true, OfficeOpenXml.Table.TableStyles.Light8);
            excel.Save();
            
            excel.Dispose();
            this._olimpPricesContext.Dispose();



            var result = PhysicalFile(Path.Combine(this._appEnvironment.WebRootPath, fullName.Replace("/", "")), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

            Response.Headers["Content-Disposition"] = new ContentDispositionHeaderValue("attachment")
            {
                FileName = file.Name
            }.ToString();

            return result;


        }

        public IActionResult ExcelFullLine()
        {
            DataTable dataTable = PricesToDataTableConverter.ConvertOlimpPricesTodataTable(this.olimpPricesFullLineContext.Prices.ToList());


            string fullName = "/" + string.Format("{0:yyyy-MM-dd_hh-mm-ss-fff}", DateTime.Now) + "data.xlsx";
            FileInfo file = new FileInfo(this._appEnvironment.WebRootPath + fullName);
            ExcelPackage excel = new ExcelPackage(file);
            var ws = excel.Workbook.Worksheets.Add("WriteTest");
            ws.Cells.LoadFromDataTable(dataTable, true, OfficeOpenXml.Table.TableStyles.Light8);
            excel.Save();

            excel.Dispose();
            this.olimpPricesFullLineContext.Dispose();



            var result = PhysicalFile(Path.Combine(this._appEnvironment.WebRootPath, fullName.Replace("/", "")), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

            Response.Headers["Content-Disposition"] = new ContentDispositionHeaderValue("attachment")
            {
                FileName = file.Name
            }.ToString();

            return result;


        }

    }
}