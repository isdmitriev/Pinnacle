using System;
using System.Collections.Generic;
using System.Text;
using PinnacleClasses.Tasks;
namespace PinnacleClasses.Tasks.Singletons
{
  public  class PinnacleEventsShedulerSingleton
    {
        private static PinnacleEventsSheduler sheduler = null;
        public static PinnacleEventsSheduler GetInstance()
        {
            if (sheduler == null)
            {
                sheduler = new PinnacleEventsSheduler();
                return sheduler;
            }
            else
            {
                return sheduler;
            }
        }
    }
}
