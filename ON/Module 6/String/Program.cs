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

            //the index starts at 0 and keeps iterating as long as its in range of "message"
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }
                     
        }
    }
}
