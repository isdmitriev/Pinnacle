using System;
using System.Collections.Generic;
using System.Text;
using Olimp.Tasks;
namespace Olimp.Singletons
{
   public class OlimpEventsShedulerSingleton
    {
        private static OlimpEventsSheduler sheduler = null;
        public static OlimpEventsSheduler GetInstance()
        {
            if (sheduler == null)
            {
                sheduler = new OlimpEventsSheduler();
                return sheduler;
            }
            else
            {
                return sheduler;
            }
        }
    }

}
