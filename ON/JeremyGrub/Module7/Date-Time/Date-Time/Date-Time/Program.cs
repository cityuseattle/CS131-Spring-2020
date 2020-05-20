using System;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            int numDays = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            Console.WriteLine(currentDate.Month);
            Console.WriteLine(numDays); 
        }
    }
}
