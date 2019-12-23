using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PinnacleClasses.Tasks;
using PinnacleClasses.Tasks.Singletons;
namespace PinnacleWeb.Controllers
{
    public class ParserController : Controller
    {
        private readonly PinnacleEventsSheduler eventsSheduler = PinnacleEventsShedulerSingleton.GetInstance();
        public IActionResult ParserView()
        {
            return View();
        }

        public IActionResult StartPrematch()
        {
           var startTask= this.eventsSheduler.StartAsync();
            startTask.Wait();
            return RedirectToAction("StartView");
        }

        public async Task<IActionResult> StopPrematch()
        {
            await this.eventsSheduler.StopAsync();
            return RedirectToAction("StopView");
        }

        public IActionResult StartLive()
        {
            var task = this.eventsSheduler.StartAsyncLive();
            task.Wait();
            return RedirectToAction("StartLiveView");
        }

        public IActionResult StopLive()
        {
            var task = this.eventsSheduler.StopLiveAsync();
            task.Wait();
            return RedirectToAction("StopLiveView");
        }

        public IActionResult StartView()
        {
            return View();
        }

        public IActionResult StopView()
        {
            return View();
        }

        public IActionResult StartLiveView()
        {
            return View();
        }
        public IActionResult StopLiveView()
        {
            return View();
        }

    }
}