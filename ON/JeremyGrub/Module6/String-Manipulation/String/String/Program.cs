using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Welcome = "Welcome to ";
            string CourseName = "CS131";
            string message = Welcome + CourseName;

            for (int i = 0; i < message.Length; i++)
               
            {
                if (i%2 == 0)
                {
                    Console.Write(message[i]);
                }
            }
        }
    }
}
