using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Welcome = "Welcome to ";
            string CourseName = "CS131";
            // Concatenate string using concat() built in method
            string message = string.Concat(Welcome, CourseName);

            // Returns the number of characters including spaces in string message
            Console.WriteLine(message.Length);
        }
    }
}
