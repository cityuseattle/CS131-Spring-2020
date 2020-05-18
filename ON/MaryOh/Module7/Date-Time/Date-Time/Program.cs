using System;

namespace Date_Time
{
    class Program
    {
        void GetPersonalInfo()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the year you were born: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            int age = (Convert.ToInt32(DateTime.Now.Year) - birthYear);

            Console.WriteLine("Here is what we know form your inputs:");
            Console.WriteLine("Your name: " + name);
            Console.WriteLine("Today is " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Your age: " + age);
        }

        static void Main(string[] args)
        {
            // create an object of class program
            // access a method of that class
            Program MyProgram = new Program();

            MyProgram.GetPersonalInfo();
        }
    }
}
