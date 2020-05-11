using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Welcome = "Welcome to ";
            string CourseName = "CS131";
            // Concatenate string using concat() method
            string message1 = string.Concat(Welcome, CourseName);
            // Concatenate string by substitutes values of variables into placeholders in a string
            string message2 = $"Printing strings for the second time: {Welcome} {CourseName}";

            Console.WriteLine(message1);
            Console.WriteLine(message2);
        }
    }
}
