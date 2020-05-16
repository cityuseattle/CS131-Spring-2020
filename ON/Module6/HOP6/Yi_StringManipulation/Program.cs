using System;
using System.Diagnostics.Tracing;

namespace Yi_StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Welcome = "Welcome to ";
            string CourseName = "CS131";

            string message = string.Concat(Welcome, CourseName); //concatenate strings using concat() method

            Console.WriteLine(message);
            
            //the index starts at 0 and keeps iterating, as long as it's in range of "message"
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }
            
            
            //Challenge section to print out every other letter in the string
            for (int i = 0; i < message.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(message[i]);
                }
            }
            
        }
    }
}