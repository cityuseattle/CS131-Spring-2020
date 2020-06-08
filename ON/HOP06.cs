using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Welcome = "Weclome to ";
            string CourseName = "CS131";
            string message = Welcome + CourseName;

            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }
        }
    }
}
