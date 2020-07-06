using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts1 = new TimeSpan(4, 6, 10, 35);
            
            Console.WriteLine("Total Hours:{0}", ts1.TotalHours.ToString("N2"));
        }
    }
}
