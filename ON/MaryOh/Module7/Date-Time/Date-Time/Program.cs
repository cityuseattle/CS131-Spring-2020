using System;

namespace Date_Time
{
    class Program
    {
        void ShowTime()
        {
            DateTime currentDate = DateTime.Now;
            bool leapYear = DateTime.IsLeapYear(2020);

            Console.WriteLine(currentDate);
            Console.Write("2020 is a leap year: ");
            Console.WriteLine(leapYear);
        }

        static void Main(string[] args)
        {
            // create an object of class program
            // access a method of that class
            Program MyProgram = new Program();

            MyProgram.ShowTime();
        }
    }
}
