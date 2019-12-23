using System;
using System.Collections.Generic;
using System.Text;

namespace Olimp.Singletons
{
    class EventIdsListSingleton
    {
        private static List<string> eventIds;

        public static List<string> GetInstance()
        {
            if (eventIds == null)
            {
                eventIds = new List<string>();
                return eventIds;
            }
            else
            {
                return eventIds;
            }
        }

        public static void AddId(string eventId)
        {
            if (ContainsEventId(eventId) == false)
                GetInstance().Add(eventId);
        }

        public static void DeleteId(string eventId)
        {
            GetInstance().Remove(eventId);
        }

        public static bool ContainsEventId(string eventId)
        {
            return GetInstance().Contains(eventId);
        }



    }

   
}
