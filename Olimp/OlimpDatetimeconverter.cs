using System;
using System.Collections.Generic;
using System.Text;
using Olimp.Dto;
using System.Globalization;
namespace Olimp
{
  public  class OlimpDatetimeconverter
    {

        public (DateTime ? startTime,double timeDisc) GetDateTime(OlimpEvent ev )
        {
            string monthComponent = ev.StartDate.Substring(0, ev.StartDate.IndexOf(" "));

            string timeComponent = ev.StartDate.Substring(ev.StartDate.LastIndexOf(" ") + 1);

            string day = ev.StartDate.Substring(ev.StartDate.IndexOf(" ") + 1, 2);

            TimeSpan span = TimeSpan.ParseExact(timeComponent,"c",null);
            


            DateTime dateTime;

            if (monthComponent == "Dec")
            {

                dateTime = new DateTime(2019, 12, Int32.Parse(day), span.Hours, span.Minutes, span.Seconds);
                

                double timeDisc = ((DateTime)dateTime - (DateTime)DateTime.Now).TotalMinutes;

                return (dateTime, timeDisc);

            }

            else
            {
                return (null, 0);
            }

            



            
            
           
        }
    }
}
