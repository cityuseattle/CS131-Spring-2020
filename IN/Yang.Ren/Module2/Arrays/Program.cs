using System;
using System.Runtime.CompilerServices;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5]; //creating a new a
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            // numbers[4] = 5;

            //print out the whole array
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //  Console.WriteLine(numbers[i] + " ");
            //}
            //foreach (int number in numbers)
            //{
            //Console.Write(number + " ");
            //}
            //}
            string[] words = new string[4]; //creating a new a
            words[0] = "This";
            words[1] = "is";
            words[2] = "a";
            words[3] = "string";
        
            
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}
