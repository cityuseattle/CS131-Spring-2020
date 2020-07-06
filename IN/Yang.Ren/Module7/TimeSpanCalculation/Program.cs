using System;
using System.Net.Http.Headers;

namespace TimeSpanCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int YR = 1995, MTH = 6, DY = 13;
            DateTime birthday = new DateTime(YR, MTH, DY);

        

            Console.WriteLine("I was born on a {0}", birthday.DayOfWeek);
        }
    }
}
