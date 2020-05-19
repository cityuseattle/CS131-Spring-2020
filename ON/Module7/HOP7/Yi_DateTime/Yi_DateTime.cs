using System;

namespace Yi_DateTime
{
    class Program
    {
        void ShowTime()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("What year were you born?: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            int age = (Convert.ToInt32(DateTime.Now.Year) - birthYear);
            
            //Challenge Portion
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            
            Console.WriteLine("Here is what we know from your inputs: ");
            Console.WriteLine("Your name: " + name);
            Console.WriteLine("Today is: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Your age: " + age);
            //Displays the days in the current month
            Console.WriteLine($"The amount of days in {month}, {year} are {DateTime.DaysInMonth(year,month)} days.");
        }
        static void Main(string[] args)
        {
            Program MyProgram = new Program();

            MyProgram.ShowTime();
        }
    }
}