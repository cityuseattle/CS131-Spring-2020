﻿using System;

namespace Date_Time
{
    class Program
    {
        void GetPersonalInfo()
        {
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("What year were you born?: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            int age = Convert.ToInt32(DateTime.Now.Year) - birthYear;

            Console.WriteLine("Here are what we know from your inputs: ");
            Console.WriteLine("Your name: " + name);
            Console.WriteLine("Today is: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Your age: " + age);
            
        }

        static void Main(string[] args)
        {
            Program MyProgram = new Program();

            MyProgram.GetPersonalInfo();
        }
    }
}
