using System;
using PinnacleClasses;
using PinnacleClasses.Responses;
using PinnacleClasses.PythonClients;
using PinnacleClasses.Dto;
using System.Globalization;
using System.Collections.Generic;
using PinnacleClasses.Converters;
using PinnacleClasses.DatabaseObjects;
using PinnacleClasses.Datacontext;
using System.Threading.Tasks;
using System.Threading;
using PinnacleClasses.Tasks;


namespace Pinnacle
{
  
    class Program
    {
        static   void Main(string[] args)
        {
            EventsHandler eventHandler = new EventsHandler();
            eventHandler.SetComputedPinnaclePricesToDatabase(30, false);

            //Eventscheduler.Start();





            Console.ReadLine();
            
            
        }
    }
}
