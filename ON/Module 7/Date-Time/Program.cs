using System;

namespace Date_Time
{
    class Program
    {
        void ShowTime()
        {
            DateTime currentMonth = DateTime.Now;
            DateTime daysInMonth = DateTime.Now;
            Console.WriteLine(currentMonth );
            Console.WriteLine(daysInMonth);
        }
        static void Main(string[] args)

        {
            Program MyProgram = new Program();
            MyProgram.ShowTime();
        }


      
    }

       
}
