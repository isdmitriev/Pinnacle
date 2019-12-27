using System;
using System.Collections.Generic;
using System.Text;
using Olimp.Dto;
using System.Globalization;
namespace Olimp
{
    public class OlimpDatetimeconverter
    {

        public (DateTime ? startTime, double timeDisc) GetDateTime(string ev)
        {
            string monthComponent = ev.Substring(0, ev.IndexOf(" "));

            
            string timeComponent = ev.Substring(ev.LastIndexOf(" ") + 1);

            string day = ev.Substring(ev.IndexOf(" ") + 1, 2);

            TimeSpan span = TimeSpan.ParseExact(timeComponent, "c", null);



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

        public double timedisc(DateTime  date)
        {
            TimeSpan   timeDisc = ((DateTime)date - (DateTime)DateTime.Now);
            return timeDisc.TotalMinutes;
        }

        public DateTime? GetDateTimeFull(string olimpEvent)
        {
            if (this.GetDateTime(olimpEvent).startTime != null)
            {
                return this.GetDateTime(olimpEvent).startTime;
            }
            else
            {
                int monthNumber = 1;
                int earNumber = 2020;

                string monthComponent = olimpEvent.Substring(0, olimpEvent.IndexOf(" "));


                string day = olimpEvent.Substring(olimpEvent.IndexOf(" ") + 1, 2);

                string timeComponent = olimpEvent.Substring(olimpEvent.LastIndexOf(" ") + 1);

                int dayNumber = Int32.Parse(day.Replace("0", ""));

                TimeSpan span = TimeSpan.ParseExact(timeComponent, "c", null);

                DateTimeFormatInfo dateTimeFormat = new DateTimeFormatInfo();
                DateTime? dateTime = null;

                var result = this.GetDateTime(olimpEvent);

                string[] names = dateTimeFormat.MonthNames;
                int i = 1;

                foreach (string s in names)
                {
                    if (s.StartsWith(monthComponent) == true)
                    {
                        monthNumber = i;
                    }
                    i = i + 1;
                }

                dateTime = new DateTime(2020, monthNumber, dayNumber, span.Hours, span.Minutes, span.Seconds);

                return dateTime;
            }
        }

        
    }
}


            
            
           
        
    

