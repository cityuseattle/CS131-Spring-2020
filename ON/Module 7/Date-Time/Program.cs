using System;

namespace Date_Time
{
    class Program
    {
        //create method for displaying number of days in the month
        void DisplayDaysInMonth()
        {
            const int May = 5;
            int monthDays = DateTime.DaysInMonth(2020, May);
            Console.WriteLine(monthDays);

        }
        //create methos for displaying current month
        void DisplayCurrentMonth()
        {
            //create DateTime and have it grab current date
            DateTime dT = DateTime.Now;
            //call .Month on dT to display the current month
            Console.WriteLine(dT.Month);
        }


        static void Main(string[] args)
        {
            //create new object of class Program
            //use this object to access DisplayDaysInMonth()
            //and DisplayCurrentMonth()
            Program Myprogram = new Program();
            Myprogram.DisplayCurrentMonth();
            Myprogram.DisplayDaysInMonth();
            
        }
    }
}
