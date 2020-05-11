using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Welcome = "Welcome to ";
            string CourseName = "CS131";
            // Concatenate string
            string message = Welcome.ToUpper() + CourseName.ToLower();

            Console.WriteLine(message);
        }
    }
}
