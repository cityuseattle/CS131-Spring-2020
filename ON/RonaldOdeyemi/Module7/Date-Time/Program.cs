using System;
using System.Security;

namespace Date_Time
{
    class Program
    {
        //void GetPersonalInfo()
        //{
            //Console.WriteLine("Enter Your Name: ");
           // string name = Console.ReadLine();

           // Console.WriteLine("What year were you born?: ");
            //int birthYear = Convert.ToInt32(Console.ReadLine());

           // int age = (Convert.ToInt32(DateTime.Now.Year) - birthYear);

           // Console.WriteLine("Here are what we know from your inputs: ");
           // Console.WriteLine("Your name: " + name);
           // Console.WriteLine("Today is: " + DateTime.Now.ToShortTimeString());
            //Console.WriteLine("Your age: " + age);
       // }
        static void Main(string[] args)
        {
                        
            Console.WriteLine(DateTime.Now.Month); // this current month

            Console.WriteLine(DateTime.DaysInMonth(2020, 5)); // the number of days this month
        }
    }
}
