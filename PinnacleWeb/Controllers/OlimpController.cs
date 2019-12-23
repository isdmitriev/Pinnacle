using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Olimp.Tasks;
using Olimp.Singletons;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace PinnacleWeb.Controllers
{
    public class OlimpController : Controller
    {
        private readonly OlimpEventsSheduler _olimpEventsSheduler = OlimpEventsShedulerSingleton.GetInstance();
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

    }
}