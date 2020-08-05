using System;

namespace TimeSpan1
{
    class TimeSpan1Class
    {
        static void Main(string[] args)
        {
            const int DAY = 1, HRS = 8, MIN = 30, SEC = 40; //Constants for TimeSpan.
            TimeSpan interval = new TimeSpan(DAY, HRS, MIN, SEC); //Create TimeSpan.

            //Display different properties of TimeSpan.
            Console.WriteLine("No Of Days: " + interval.Days.ToString("N2"));
            Console.WriteLine("No Of Hrs:" + interval.Hours.ToString("N2"));
            Console.WriteLine("No Of Minutes:" + interval.Minutes.ToString("N2"));
            Console.WriteLine("No Of seconds: " + interval.Seconds.ToString("N2"));
            Console.WriteLine("Total Days: " + interval.TotalDays.ToString("N2"));
            Console.WriteLine("Total Hrs:" + interval.TotalHours.ToString("N2"));
            Console.WriteLine("Total  Minutes:" + interval.TotalMinutes.ToString("N2"));
            Console.WriteLine("Total Seconds " + interval.TotalSeconds.ToString("N2"));
        }
    }
}
