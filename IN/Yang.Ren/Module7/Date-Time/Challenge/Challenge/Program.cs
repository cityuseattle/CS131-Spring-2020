using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            int days = DateTime.DaysInMonth(dt.Year, dt.Month);
            int month = DateTime.Now.Month;
           
            Console.WriteLine(month);
            Console.WriteLine(days);

        }
    }
}
