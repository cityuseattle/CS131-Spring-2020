using System;

namespace Date_Time
{
    class Program
    {
        void MonthDay()
        {
            // get current month
            int month = DateTime.Now.Month;
            Console.WriteLine(month);

            // get number of days of this month
            int day = DateTime.DaysInMonth(DateTime.Now.Year, month);
            Console.WriteLine(day);
        }

        static void Main(string[] args)
        {
            // create an object of class program
            // access a method of that class
            Program MyProgram = new Program();

            MyProgram.MonthDay();
        }
    }
}
