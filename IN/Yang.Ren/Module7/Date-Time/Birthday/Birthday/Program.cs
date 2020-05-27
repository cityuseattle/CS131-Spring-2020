using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(1995, 06, 11);
            int year = birthday.Year;
            int month = birthday.Month;
            int day = birthday.Day;
            string birthday1 = birthday.ToString("D");

            Console.WriteLine(year);
            Console.WriteLine(month);
            Console.WriteLine(day);
            Console.WriteLine(birthday1);
        }
    }
}
