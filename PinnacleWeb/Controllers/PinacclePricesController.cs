using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PinnacleClasses.DatabaseObjects;
using PinnacleClasses.Datacontext;
using PinnacleClasses.Converters;
using System.IO;
using ClosedXML.Excel;
using ClosedXML;
using System.Data;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using PinnacleClasses.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;
namespace PinnacleWeb.Controllers
{
    public class PinacclePricesController : Controller
    {
        private readonly PinnaclePricesContext _context;
        IHostingEnvironment _appEnvironment;
        public PinacclePricesController(IHostingEnvironment appEnvironment)
        {
            _context = new PinnaclePricesContext();
            _appEnvironment = appEnvironment;
        }

        // GET: PinacclePrices
        public async Task<IActionResult> Index()
        {
            return View(await _context.Prices.Take(30000).OrderByDescending(p=>p.DateAdded).ToListAsync());
        }

        public IActionResult Index2()
        {
            return View();
        }

        public  IActionResult Excel()
        {
            //int count = this._context.Prices.Count() - 30000;
            //DataTable tab = PinacclePricesTodatatableConverter.ConvertPinacclePricesTodataTable(await this._context.Prices.ToListAsync());

            //tab.TableName = "pinnacleprices";
            //string fileName = "Sample.xlsx";
            //using (XLWorkbook wb = new XLWorkbook())
            //{

            //    wb.Worksheets.Add(tab);
            //    using (MemoryStream stream = new MemoryStream())
            //    {
            //        wb.SaveAs(stream);

            //        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
            //    }
            //}




            DataTable table = PinacclePricesTodatatableConverter.ConvertPinacclePricesTodataTable(_context.Prices.ToList());
            string fullName = "/" + string.Format("{0:yyyy-MM-dd_hh-mm-ss-fff}", DateTime.Now) + "data.xlsx";
            FileInfo file = new FileInfo(this._appEnvironment.WebRootPath +fullName);
            ExcelPackage excel = new ExcelPackage(file);
            var ws = excel.Workbook.Worksheets.Add("WriteTest");
            ws.Cells.LoadFromDataTable(table, true, OfficeOpenXml.Table.TableStyles.Light8);
            excel.Save();



            var result = PhysicalFile(Path.Combine(this._appEnvironment.WebRootPath, fullName.Replace("/","")), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

            Response.Headers["Content-Disposition"] = new ContentDispositionHeaderValue("attachment")
            {
                FileName = file.Name
            }.ToString();

            return result;


        }

        public IActionResult StartParser()
        {
            
            return RedirectToAction("Index");
        }


        // GET: PinacclePrices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pinacclePrices = await _context.Prices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pinacclePrices == null)
            {
                return NotFound();
            }

            return View(pinacclePrices);
        }

        // GET: PinacclePrices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PinacclePrices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EventId,DateAdded,IsLive,StartTime,HomeTeam,AwayTeam,HOME,DRAW,AWAY,HOME_computed_,DRAW_computed_,AWAY_computed_,HOME_disc,DRAW_disc,AWAY_disc,HOMEAWAY,HOMEDRAW,DRAWAWAY,HOMEAWAY_computed_,HOMEDRAW_computed_,DRAWAWAY_computed_,HOMEAWAY_disc,HOMEDRAW_disc,DRAWAWAY_disc,TO_0_5,TU_0_5,TO_0_5_computed_,TU_0_5_computed_,TO_0_5_disc,TU_0_5_disc,TO_0_75,TU_0_75,TO_0_75_computed_,TU_0_75_computed_,TO_0_75_disc,TU_0_75_disc,TO_1_0,TU_1_0,TO_1_0_computed_,TU_1_0_computed_,TO_1_0_disc,TU_1_0_disc,TO_1_25,TU_1_25,TO_1_25_computed_,TU_1_25_computed_,TO_1_25_disc,TU_1_25_disc,TO_1_5,TU_1_5,TO_1_5_computed_,TU_1_5_computed_,TO_1_5_disc,TU_1_5_disc,TO_1_75,TU_1_75,TO_1_75_computed_,TU_1_75_computed_,TO_1_75_disc,TU_1_75_disc,TO_2_0,TU_2_0,TO_2_0_computed_,TU_2_0_computed_,TO_2_0_disc,TU_2_0_disc,TO_2_25,TU_2_25,TO_2_25_computed_,TU_2_25_computed_,TO_2_25_disc,TU_2_25_disc,TO_2_5,TU_2_5,TO_2_5_computed_,TU_2_5_computed_,TO_2_5_disc,TU_2_5_disc,TO_2_75,TU_2_75,TO_2_75_computed_,TU_2_75_computed_,TO_2_75_disc,TU_2_75_disc,TO_3_0,TU_3_0,TO_3_0_computed_,TU_3_0_computed_,TO_3_0_disc,TU_3_0_disc,TO_3_25,TU_3_25,TO_3_25_computed_,TU_3_25_computed_,TO_3_25_disc,TU_3_25_disc,TO_3_5,TU_3_5,TO_3_5_computed_,TU_3_5_computed_,TO_3_5_disc,TU_3_5_disc,TO_3_75,TU_3_75,TO_3_75_computed_,TU_3_75_computed_,TO_3_75_disc,TU_3_75_disc,TO_4_0,TU_4_0,TO_4_0_computed_,TU_4_0_computed_,TO_4_0_disc,TU_4_0_disc,TO_4_25,TU_4_25,TO_4_45_computed_,TU_4_25_computed_,TO_4_45_disc,TU_4_25_disc,TO_4_5,TU_4_5,TO_4_5_computed_,TU_4_5_computed_,TO_4_5_disc,TU_4_5_disc,TO_4_75,TU_4_75,TO_4_75_computed_,TU_4_75_computed_,TO_4_75_disc,TU_4_75_disc,TO_5_0,TU_5_0,TO_5_0_computed_,TU_5_0_computed_,TO_5_0_disc,TU_5_0_disc,TO_5_25,TU_5_25,TO_5_25_computed_,TU_5_25_computed_,TO_5_25_disc,TU_5_25_disc,TO_5_5,TU_5_5,TO_5_5_computed_,TU_5_5_computed_,TO_5_5_disc,TU_5_5_disc,TO_5_75,TU_5_75,TO_5_75_computed_,TU_5_75_computed_,TO_5_75_disc,TU_5_75_disc,TO_6_0,TU_6_0,TO_6_0_computed_,TU_6_0_computed_,TO_6_0_disc,TU_6_0_disc,TO_6_25,TU_6_25,TO_6_25_computed_,TU_6_25_computed_,TO_6_25_disc,TU_6_25_disc,TO_6_5,TU_6_5,TO_6_5_computed_,TU_6_5_computed_,TO_6_5_disc,TU_6_5_disc,T1O_0_5,T1U_0_5,T1O_0_5_computed_,T1U_0_5_computed_,T1O_0_5_disc,T1U_0_5_disc,T1O_0_75,T1U_0_75,T1O_0_75_computed_,T1U_0_75_computed_,T1O_0_75_disc,T1U_0_75_disc,T1O_1_0,T1U_1_0,T1O_1_0_computed_,T1U_1_0_computed_,T1O_1_0_disc,T1U_1_0_disc,T1O_1_25,T1U_1_25,T1O_1_25_computed_,T1U_1_25_computed_,T1O_1_25_disc,T1U_1_25_disc,T1O_1_5,T1U_1_5,T1O_1_5_computed_,T1U_1_5_computed_,T1O_1_5_disc,T1U_1_5_disc,T1O_1_75,T1U_1_75,T1O_1_75_computed_,T1U_1_75_computed_,T1O_1_75_disc,T1U_1_75_disc,T1O_2_0,T1U_2_0,T1O_2_0_computed_,T1U_2_0_computed_,T1O_2_0_disc,T1U_2_0_disc,T1O_2_25,T1U_2_25,T1O_2_25_computed_,T1U_2_25_computed_,T1O_2_25_disc,T1U_2_25_disc,T1O_2_5,T1U_2_5,T1O_2_5_computed_,T1U_2_5_computed_,T1O_2_5_disc,T1U_2_5_disc,T1O_2_75,T1U_2_75,T1O_2_75_computed_,T1U_2_75_computed_,T1O_2_75_disc,T1U_2_75_disc,T1O_3_0,T1U_3_0,T1O_3_0_computed_,T1U_3_0_computed_,T1O_3_0_disc,T1U_3_0_disc,T1O_3_25,T1U_3_25,T1O_3_25_computed_,T1U_3_25_computed_,T1O_3_25_disc,T1U_3_25_disc,T1O_3_5,T1U_3_5,T1O_3_5_computed_,T1U_3_5_computed_,T1O_3_5_disc,T1U_3_5_disc,T1O_3_75,T1U_3_75,T1O_3_75_computed_,T1U_3_75_computed_,T1O_3_75_disc,T1U_3_75_disc,T1O_4_0,T1U_4_0,T1O_4_0_computed_,T1U_4_0_computed_,T1O_4_0_disc,T1U_4_0_disc,T1O_4_25,T1U_4_25,T1O_4_25_computed_,T1U_4_25_computed_,T1O_4_25_disc,T1U_4_25_disc,T1O_4_5,T1U_4_5,T1O_4_5_computed_,T1U_4_5_computed_,T1O_4_5_disc,T1U_4_5_disc,T2O_0_5,T2U_0_5,T2O_0_5_computed_,T2U_0_5_computed_,T2O_0_5_disc,T2U_0_5_disc,T2O_0_75,T2U_0_75,T2O_0_75_computed_,T2U_0_75_computed_,T2O_0_75_disc,T2U_0_75_disc,T2O_1_0,T2U_1_0,T2O_1_0_computed_,T2U_1_0_computed_,T2O_1_0_disc,T2U_1_0_disc,T2O_1_25,T2U_1_25,T2O_1_25_computed_,T2U_1_25_computed_,T2O_1_25_disc,T2U_1_25_disc,T2O_1_5,T2U_1_5,T2O_1_5_computed_,T2U_1_5_computed_,T2O_1_5_disc,T2U_1_5_disc,T2O_1_75,T2U_1_75,T2O_1_75_computed_,T2U_1_75_computed_,T2O_1_75_disc,T2U_1_75_disc,T2O_2_0,T2U_2_0,T2O_2_0_computed_,T2U_2_0_computed_,T2O_2_0_disc,T2U_2_0_disc,T2O_2_25,T2U_2_25,T2O_2_25_computed_,T2U_2_25_computed_,T2O_2_25_disc,T2U_2_25_disc,T2O_2_5,T2U_2_5,T2O_2_5_computed_,T2U_2_5_computed_,T2O_2_5_disc,T2U_2_5_disc,T2O_2_75,T2U_2_75,T2O_2_75_computed_,T2U_2_75_computed_,T2O_2_75_disc,T2U_2_75_disc,T2O_3_0,T2U_3_0,T2O_3_0_computed_,T2U_3_0_computed_,T2O_3_0_disc,T2U_3_0_disc,T2O_3_25,T2U_3_25,T2O_3_25_computed_,T2U_3_25_computed_,T2O_3_25_disc,T2U_3_25_disc,T2O_3_5,T2U_3_5,T2O_3_5_computed_,T2U_3_5_computed_,T2O_3_5_disc,T2U_3_5_disc,T2O_3_75,T2U_3_75,T2O_3_75_computed_,T2U_3_75_computed_,T2O_3_75_disc,T2U_3_75_disc,T2O_4_0,T2U_4_0,T2O_4_0_computed_,T2U_4_0_computed_,T2O_4_0_disc,T2U_4_0_disc,T2O_4_25,T2U_4_25,T2O_4_25_computed_,T2U_4_25_computed_,T2O_4_25_disc,T2U_4_25_disc,T2O_4_5,T2U_4_5,T2O_4_5_computed_,T2U_4_5_computed_,T2O_4_5_disc,T2U_4_5_disc,HOME_HDP_3_5,AWAY_HDP__3_5,HOME_HDP_3_5_computed,AWAY_HDP__3_5_computed,HOME_HDP_3_5_disc,AWAY_HDP__3_5_disc,HOME_HDP_3_0,AWAY_HDP__3_0,HOME_HDP_3_0_computed,AWAY_HDP__3_0_computed,HOME_HDP_3_0_disc,AWAY_HDP__3_0_disc,HOME_HDP_2_75,AWAY_HDP__2_75,HOME_HDP_2_75_computed,AWAY_HDP__2_75_computed,HOME_HDP_2_75_disc,AWAY_HDP__2_75_disc,HOME_HDP_2_5,AWAY_HDP__2_5,HOME_HDP_2_5_computed,AWAY_HDP__2_5_computed,HOME_HDP_2_5_disc,AWAY_HDP__2_5_disc,HOME_HDP_2_0,AWAY_HDP__2_0,HOME_HDP_2_0_computed,AWAY_HDP__2_0_computed,HOME_HDP_2_0_disc,AWAY_HDP__2_0_disc,HOME_HDP_1_75,AWAY_HDP__1_75,HOME_HDP_1_75_computed,AWAY_HDP__1_75_computed,HOME_HDP_1_75_disc,AWAY_HDP__1_75_disc,HOME_HDP_1_5,AWAY_HDP__1_5,HOME_HDP_1_5_computed,AWAY_HDP__1_5_computed,HOME_HDP_1_5_disc,AWAY_HDP__1_5_disc,HOME_HDP_1_0,AWAY_HDP__1_0,HOME_HDP_1_0_computed,AWAY_HDP__1_0_computed,HOME_HDP_1_0_disc,AWAY_HDP__1_0_disc,HOME_HDP_0_75,AWAY_HDP__0_75,HOME_HDP_0_75_computed,AWAY_HDP__0_75_computed,HOME_HDP_0_75_disc,AWAY_HDP__0_75_disc,HOME_HDP_0_5,AWAY_HDP__0_5,HOME_HDP_0_5_computed,AWAY_HDP__0_5_computed,HOME_HDP_0_5_disc,AWAY_HDP__0_5_disc,HOME_HDP_0_25,AWAY_HDP__0_25,HOME_HDP_0_25_computed,AWAY_HDP__0_25_computed,HOME_HDP_0_25_disc,AWAY_HDP__0_25_disc,HOME_HDP_0_0,AWAY_HDP_0_0,HOME_HDP_0_0_computed,AWAY_HDP_0_0_computed,HOME_HDP_0_0_disc,AWAY_HDP_0_0_disc,HOME_HDP__0_25,AWAY_HDP_0_25,HOME_HDP__0_25_computed,AWAY_HDP_0_25_computed,HOME_HDP__0_25_disc,AWAY_HDP_0_25_disc,HOME_HDP__0_5,AWAY_HDP_0_5,HOME_HDP__0_5_computed,AWAY_HDP_0_5_computed,HOME_HDP__0_5_disc,AWAY_HDP_0_5_disc,HOME_HDP__0_75,AWAY_HDP_0_75,HOME_HDP__0_75_computed,AWAY_HDP_0_75_computed,HOME_HDP__0_75_disc,AWAY_HDP_0_75_disc,HOME_HDP__1_0,AWAY_HDP_1_0,HOME_HDP__1_0_computed,AWAY_HDP_1_0_computed,HOME_HDP__1_0_disc,AWAY_HDP_1_0_disc,HOME_HDP__1_25,AWAY_HDP_1_25,HOME_HDP__1_25_computed,AWAY_HDP_1_25_computed,HOME_HDP__1_25_disc,AWAY_HDP_1_25_disc,HOME_HDP__1_5,AWAY_HDP_1_5,HOME_HDP__1_5_computed,AWAY_HDP_1_5_computed,HOME_HDP__1_5_disc,AWAY_HDP_1_5_disc,HOME_HDP__2_0,AWAY_HDP_2_0,HOME_HDP__2_0_computed,AWAY_HDP_2_0_computed,HOME_HDP__2_0_disc,AWAY_HDP_2_0_disc,HOME_HDP__2_25,AWAY_HDP_2_25,HOME_HDP__2_25_computed,AWAY_HDP_2_25_computed,HOME_HDP__2_25_disc,AWAY_HDP_2_25_disc,HOME_HDP__2_5,AWAY_HDP_2_5,HOME_HDP__2_5_computed,AWAY_HDP_2_5_computed,HOME_HDP__2_5_disc,AWAY_HDP_2_5_disc,HOME_HDP__2_75,AWAY_HDP_2_75,HOME_HDP__2_75_computed,AWAY_HDP_2_75_computed,HOME_HDP__2_75_disc,AWAY_HDP_2_75_disc,HOME_HDP__3_0,AWAY_HDP_3_0,HOME_HDP__3_0_computed,AWAY_HDP_3_0_computed,HOME_HDP__3_0_disc,AWAY_HDP_3_0_disc,HOME_HDP__3_25,AWAY_HDP_3_25,HOME_HDP__3_25_computed,AWAY_HDP_3_25_computed,HOME_HDP__3_25_disc,AWAY_HDP_3_25_disc,HOME_HDP__3_5,AWAY_HDP_3_5,HOME_HDP__3_5_computed,AWAY_HDP_3_5_computed,HOME_HDP__3_5_disc,AWAY_HDP_3_5_disc")] PinacclePrices pinacclePrices)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pinacclePrices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pinacclePrices);
        }

        // GET: PinacclePrices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pinacclePrices = await _context.Prices.FindAsync(id);
            if (pinacclePrices == null)
            {
                return NotFound();
            }
            return View(pinacclePrices);
        }

        // POST: PinacclePrices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EventId,DateAdded,IsLive,StartTime,HomeTeam,AwayTeam,HOME,DRAW,AWAY,HOME_computed_,DRAW_computed_,AWAY_computed_,HOME_disc,DRAW_disc,AWAY_disc,HOMEAWAY,HOMEDRAW,DRAWAWAY,HOMEAWAY_computed_,HOMEDRAW_computed_,DRAWAWAY_computed_,HOMEAWAY_disc,HOMEDRAW_disc,DRAWAWAY_disc,TO_0_5,TU_0_5,TO_0_5_computed_,TU_0_5_computed_,TO_0_5_disc,TU_0_5_disc,TO_0_75,TU_0_75,TO_0_75_computed_,TU_0_75_computed_,TO_0_75_disc,TU_0_75_disc,TO_1_0,TU_1_0,TO_1_0_computed_,TU_1_0_computed_,TO_1_0_disc,TU_1_0_disc,TO_1_25,TU_1_25,TO_1_25_computed_,TU_1_25_computed_,TO_1_25_disc,TU_1_25_disc,TO_1_5,TU_1_5,TO_1_5_computed_,TU_1_5_computed_,TO_1_5_disc,TU_1_5_disc,TO_1_75,TU_1_75,TO_1_75_computed_,TU_1_75_computed_,TO_1_75_disc,TU_1_75_disc,TO_2_0,TU_2_0,TO_2_0_computed_,TU_2_0_computed_,TO_2_0_disc,TU_2_0_disc,TO_2_25,TU_2_25,TO_2_25_computed_,TU_2_25_computed_,TO_2_25_disc,TU_2_25_disc,TO_2_5,TU_2_5,TO_2_5_computed_,TU_2_5_computed_,TO_2_5_disc,TU_2_5_disc,TO_2_75,TU_2_75,TO_2_75_computed_,TU_2_75_computed_,TO_2_75_disc,TU_2_75_disc,TO_3_0,TU_3_0,TO_3_0_computed_,TU_3_0_computed_,TO_3_0_disc,TU_3_0_disc,TO_3_25,TU_3_25,TO_3_25_computed_,TU_3_25_computed_,TO_3_25_disc,TU_3_25_disc,TO_3_5,TU_3_5,TO_3_5_computed_,TU_3_5_computed_,TO_3_5_disc,TU_3_5_disc,TO_3_75,TU_3_75,TO_3_75_computed_,TU_3_75_computed_,TO_3_75_disc,TU_3_75_disc,TO_4_0,TU_4_0,TO_4_0_computed_,TU_4_0_computed_,TO_4_0_disc,TU_4_0_disc,TO_4_25,TU_4_25,TO_4_45_computed_,TU_4_25_computed_,TO_4_45_disc,TU_4_25_disc,TO_4_5,TU_4_5,TO_4_5_computed_,TU_4_5_computed_,TO_4_5_disc,TU_4_5_disc,TO_4_75,TU_4_75,TO_4_75_computed_,TU_4_75_computed_,TO_4_75_disc,TU_4_75_disc,TO_5_0,TU_5_0,TO_5_0_computed_,TU_5_0_computed_,TO_5_0_disc,TU_5_0_disc,TO_5_25,TU_5_25,TO_5_25_computed_,TU_5_25_computed_,TO_5_25_disc,TU_5_25_disc,TO_5_5,TU_5_5,TO_5_5_computed_,TU_5_5_computed_,TO_5_5_disc,TU_5_5_disc,TO_5_75,TU_5_75,TO_5_75_computed_,TU_5_75_computed_,TO_5_75_disc,TU_5_75_disc,TO_6_0,TU_6_0,TO_6_0_computed_,TU_6_0_computed_,TO_6_0_disc,TU_6_0_disc,TO_6_25,TU_6_25,TO_6_25_computed_,TU_6_25_computed_,TO_6_25_disc,TU_6_25_disc,TO_6_5,TU_6_5,TO_6_5_computed_,TU_6_5_computed_,TO_6_5_disc,TU_6_5_disc,T1O_0_5,T1U_0_5,T1O_0_5_computed_,T1U_0_5_computed_,T1O_0_5_disc,T1U_0_5_disc,T1O_0_75,T1U_0_75,T1O_0_75_computed_,T1U_0_75_computed_,T1O_0_75_disc,T1U_0_75_disc,T1O_1_0,T1U_1_0,T1O_1_0_computed_,T1U_1_0_computed_,T1O_1_0_disc,T1U_1_0_disc,T1O_1_25,T1U_1_25,T1O_1_25_computed_,T1U_1_25_computed_,T1O_1_25_disc,T1U_1_25_disc,T1O_1_5,T1U_1_5,T1O_1_5_computed_,T1U_1_5_computed_,T1O_1_5_disc,T1U_1_5_disc,T1O_1_75,T1U_1_75,T1O_1_75_computed_,T1U_1_75_computed_,T1O_1_75_disc,T1U_1_75_disc,T1O_2_0,T1U_2_0,T1O_2_0_computed_,T1U_2_0_computed_,T1O_2_0_disc,T1U_2_0_disc,T1O_2_25,T1U_2_25,T1O_2_25_computed_,T1U_2_25_computed_,T1O_2_25_disc,T1U_2_25_disc,T1O_2_5,T1U_2_5,T1O_2_5_computed_,T1U_2_5_computed_,T1O_2_5_disc,T1U_2_5_disc,T1O_2_75,T1U_2_75,T1O_2_75_computed_,T1U_2_75_computed_,T1O_2_75_disc,T1U_2_75_disc,T1O_3_0,T1U_3_0,T1O_3_0_computed_,T1U_3_0_computed_,T1O_3_0_disc,T1U_3_0_disc,T1O_3_25,T1U_3_25,T1O_3_25_computed_,T1U_3_25_computed_,T1O_3_25_disc,T1U_3_25_disc,T1O_3_5,T1U_3_5,T1O_3_5_computed_,T1U_3_5_computed_,T1O_3_5_disc,T1U_3_5_disc,T1O_3_75,T1U_3_75,T1O_3_75_computed_,T1U_3_75_computed_,T1O_3_75_disc,T1U_3_75_disc,T1O_4_0,T1U_4_0,T1O_4_0_computed_,T1U_4_0_computed_,T1O_4_0_disc,T1U_4_0_disc,T1O_4_25,T1U_4_25,T1O_4_25_computed_,T1U_4_25_computed_,T1O_4_25_disc,T1U_4_25_disc,T1O_4_5,T1U_4_5,T1O_4_5_computed_,T1U_4_5_computed_,T1O_4_5_disc,T1U_4_5_disc,T2O_0_5,T2U_0_5,T2O_0_5_computed_,T2U_0_5_computed_,T2O_0_5_disc,T2U_0_5_disc,T2O_0_75,T2U_0_75,T2O_0_75_computed_,T2U_0_75_computed_,T2O_0_75_disc,T2U_0_75_disc,T2O_1_0,T2U_1_0,T2O_1_0_computed_,T2U_1_0_computed_,T2O_1_0_disc,T2U_1_0_disc,T2O_1_25,T2U_1_25,T2O_1_25_computed_,T2U_1_25_computed_,T2O_1_25_disc,T2U_1_25_disc,T2O_1_5,T2U_1_5,T2O_1_5_computed_,T2U_1_5_computed_,T2O_1_5_disc,T2U_1_5_disc,T2O_1_75,T2U_1_75,T2O_1_75_computed_,T2U_1_75_computed_,T2O_1_75_disc,T2U_1_75_disc,T2O_2_0,T2U_2_0,T2O_2_0_computed_,T2U_2_0_computed_,T2O_2_0_disc,T2U_2_0_disc,T2O_2_25,T2U_2_25,T2O_2_25_computed_,T2U_2_25_computed_,T2O_2_25_disc,T2U_2_25_disc,T2O_2_5,T2U_2_5,T2O_2_5_computed_,T2U_2_5_computed_,T2O_2_5_disc,T2U_2_5_disc,T2O_2_75,T2U_2_75,T2O_2_75_computed_,T2U_2_75_computed_,T2O_2_75_disc,T2U_2_75_disc,T2O_3_0,T2U_3_0,T2O_3_0_computed_,T2U_3_0_computed_,T2O_3_0_disc,T2U_3_0_disc,T2O_3_25,T2U_3_25,T2O_3_25_computed_,T2U_3_25_computed_,T2O_3_25_disc,T2U_3_25_disc,T2O_3_5,T2U_3_5,T2O_3_5_computed_,T2U_3_5_computed_,T2O_3_5_disc,T2U_3_5_disc,T2O_3_75,T2U_3_75,T2O_3_75_computed_,T2U_3_75_computed_,T2O_3_75_disc,T2U_3_75_disc,T2O_4_0,T2U_4_0,T2O_4_0_computed_,T2U_4_0_computed_,T2O_4_0_disc,T2U_4_0_disc,T2O_4_25,T2U_4_25,T2O_4_25_computed_,T2U_4_25_computed_,T2O_4_25_disc,T2U_4_25_disc,T2O_4_5,T2U_4_5,T2O_4_5_computed_,T2U_4_5_computed_,T2O_4_5_disc,T2U_4_5_disc,HOME_HDP_3_5,AWAY_HDP__3_5,HOME_HDP_3_5_computed,AWAY_HDP__3_5_computed,HOME_HDP_3_5_disc,AWAY_HDP__3_5_disc,HOME_HDP_3_0,AWAY_HDP__3_0,HOME_HDP_3_0_computed,AWAY_HDP__3_0_computed,HOME_HDP_3_0_disc,AWAY_HDP__3_0_disc,HOME_HDP_2_75,AWAY_HDP__2_75,HOME_HDP_2_75_computed,AWAY_HDP__2_75_computed,HOME_HDP_2_75_disc,AWAY_HDP__2_75_disc,HOME_HDP_2_5,AWAY_HDP__2_5,HOME_HDP_2_5_computed,AWAY_HDP__2_5_computed,HOME_HDP_2_5_disc,AWAY_HDP__2_5_disc,HOME_HDP_2_0,AWAY_HDP__2_0,HOME_HDP_2_0_computed,AWAY_HDP__2_0_computed,HOME_HDP_2_0_disc,AWAY_HDP__2_0_disc,HOME_HDP_1_75,AWAY_HDP__1_75,HOME_HDP_1_75_computed,AWAY_HDP__1_75_computed,HOME_HDP_1_75_disc,AWAY_HDP__1_75_disc,HOME_HDP_1_5,AWAY_HDP__1_5,HOME_HDP_1_5_computed,AWAY_HDP__1_5_computed,HOME_HDP_1_5_disc,AWAY_HDP__1_5_disc,HOME_HDP_1_0,AWAY_HDP__1_0,HOME_HDP_1_0_computed,AWAY_HDP__1_0_computed,HOME_HDP_1_0_disc,AWAY_HDP__1_0_disc,HOME_HDP_0_75,AWAY_HDP__0_75,HOME_HDP_0_75_computed,AWAY_HDP__0_75_computed,HOME_HDP_0_75_disc,AWAY_HDP__0_75_disc,HOME_HDP_0_5,AWAY_HDP__0_5,HOME_HDP_0_5_computed,AWAY_HDP__0_5_computed,HOME_HDP_0_5_disc,AWAY_HDP__0_5_disc,HOME_HDP_0_25,AWAY_HDP__0_25,HOME_HDP_0_25_computed,AWAY_HDP__0_25_computed,HOME_HDP_0_25_disc,AWAY_HDP__0_25_disc,HOME_HDP_0_0,AWAY_HDP_0_0,HOME_HDP_0_0_computed,AWAY_HDP_0_0_computed,HOME_HDP_0_0_disc,AWAY_HDP_0_0_disc,HOME_HDP__0_25,AWAY_HDP_0_25,HOME_HDP__0_25_computed,AWAY_HDP_0_25_computed,HOME_HDP__0_25_disc,AWAY_HDP_0_25_disc,HOME_HDP__0_5,AWAY_HDP_0_5,HOME_HDP__0_5_computed,AWAY_HDP_0_5_computed,HOME_HDP__0_5_disc,AWAY_HDP_0_5_disc,HOME_HDP__0_75,AWAY_HDP_0_75,HOME_HDP__0_75_computed,AWAY_HDP_0_75_computed,HOME_HDP__0_75_disc,AWAY_HDP_0_75_disc,HOME_HDP__1_0,AWAY_HDP_1_0,HOME_HDP__1_0_computed,AWAY_HDP_1_0_computed,HOME_HDP__1_0_disc,AWAY_HDP_1_0_disc,HOME_HDP__1_25,AWAY_HDP_1_25,HOME_HDP__1_25_computed,AWAY_HDP_1_25_computed,HOME_HDP__1_25_disc,AWAY_HDP_1_25_disc,HOME_HDP__1_5,AWAY_HDP_1_5,HOME_HDP__1_5_computed,AWAY_HDP_1_5_computed,HOME_HDP__1_5_disc,AWAY_HDP_1_5_disc,HOME_HDP__2_0,AWAY_HDP_2_0,HOME_HDP__2_0_computed,AWAY_HDP_2_0_computed,HOME_HDP__2_0_disc,AWAY_HDP_2_0_disc,HOME_HDP__2_25,AWAY_HDP_2_25,HOME_HDP__2_25_computed,AWAY_HDP_2_25_computed,HOME_HDP__2_25_disc,AWAY_HDP_2_25_disc,HOME_HDP__2_5,AWAY_HDP_2_5,HOME_HDP__2_5_computed,AWAY_HDP_2_5_computed,HOME_HDP__2_5_disc,AWAY_HDP_2_5_disc,HOME_HDP__2_75,AWAY_HDP_2_75,HOME_HDP__2_75_computed,AWAY_HDP_2_75_computed,HOME_HDP__2_75_disc,AWAY_HDP_2_75_disc,HOME_HDP__3_0,AWAY_HDP_3_0,HOME_HDP__3_0_computed,AWAY_HDP_3_0_computed,HOME_HDP__3_0_disc,AWAY_HDP_3_0_disc,HOME_HDP__3_25,AWAY_HDP_3_25,HOME_HDP__3_25_computed,AWAY_HDP_3_25_computed,HOME_HDP__3_25_disc,AWAY_HDP_3_25_disc,HOME_HDP__3_5,AWAY_HDP_3_5,HOME_HDP__3_5_computed,AWAY_HDP_3_5_computed,HOME_HDP__3_5_disc,AWAY_HDP_3_5_disc")] PinacclePrices pinacclePrices)
        {
            if (id != pinacclePrices.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pinacclePrices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PinacclePricesExists(pinacclePrices.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pinacclePrices);
        }

        // GET: PinacclePrices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pinacclePrices = await _context.Prices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pinacclePrices == null)
            {
                return NotFound();
            }

            return View(pinacclePrices);
        }

        // POST: PinacclePrices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pinacclePrices = await _context.Prices.FindAsync(id);
            _context.Prices.Remove(pinacclePrices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PinacclePricesExists(int id)
        {
            return _context.Prices.Any(e => e.Id == id);
        }
    }
}
