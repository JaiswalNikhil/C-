using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace watch
{
    class StopWatch
    {
         

        public static TimeSpan Start<T>() where T : new()
        {
            var Hours = DateTime.Now.Hour;
            var Minute = DateTime.Now.Minute;
            var Seconds = DateTime.Now.Second;

            TimeSpan timespan = new TimeSpan(Hours, Minute, Seconds);
            return timespan;
        }

        public static TimeSpan Stop<T>() where T : new()
        {

            var Hours = DateTime.Now.Hour;
            var Minute = DateTime.Now.Minute;
            var Seconds = DateTime.Now.Second;

            TimeSpan timespan = new TimeSpan(Hours, Minute, Seconds);
            return timespan;
        }

        public static void  CalculateDuration(TimeSpan time1 , TimeSpan time2)
        {
            var Total_Hours = time2.Hours - time1.Hours;
            var Total_Minutes = time2.Minutes - time1.Minutes;
            var Total_Seconds = time2.Seconds - time1.Seconds;

            TimeSpan time = new TimeSpan(Total_Hours, Total_Minutes, Total_Seconds);

           
            Console.WriteLine("\n\n\t\t Time : " + time);
           

        }

        
    }
}
