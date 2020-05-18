using System;
using System.Reflection;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Welcome = "Welcome to ";                //variable string declared
            string CourseName = "CS131";                  //variable string declared
            string message = Welcome + CourseName;        //concatenate string    

            for (int i = 0; i < message.Length; i++)       
            {
                if ((i % 2) == 0)
                {
                  Console.Write(message[i]);               //prints the value starting at even index
                }
            }
            Console.WriteLine();
        }
    }
}
