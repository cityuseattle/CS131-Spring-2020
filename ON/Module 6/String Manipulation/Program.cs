using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // create string variables
            string Welcome = "Welcome to ";
            string CourseName = "CS131";
            string message = Welcome + CourseName;

            //use for loop to iterate over each letter in message
            // for the legnth of the message variable
            for (int i = 0; i < message.Length; i++)
            {
                if (i % 2 == 0)
                {
                    // write out each letter at the index if i % 2 is 0
                    Console.Write(message[i]);
                }

            }

        }
    }
}
