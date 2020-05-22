using System;

namespace Date_Time
{
    class Program
    {
        void ShowTime()
        {
            DateTime currentDateTime = DateTime.Now; //Creates current DateTime object 
            Console.WriteLine(currentDateTime.Month);  //Displays current month.
            Console.WriteLine(DateTime.DaysInMonth(currentDateTime.Year, currentDateTime.Month)); //gets no of days in current month.
        }
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.ShowTime();
        }
    }
}
