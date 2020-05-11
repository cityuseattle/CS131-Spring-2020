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

            // Prints the character at index 0 of the string Welcome
            Console.WriteLine(Welcome[0]);
            // Prints the last character of string CourseName
            Console.WriteLine(CourseName.Substring(CourseName.Length - 1));
        }
    }
}
