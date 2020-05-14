using System;
using System.Runtime.CompilerServices;

namespace Yi_StringLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize the string array.
            //In this case this is the first sentence out of a lorem ipsum block
            string[] Sentence = new string[]
            {
                "Lorem", "ipsum", "dolor", "sit", "amet,", "consectetur", "adipiscing", "elit,", "sed", "do", "eiusmod",
                "tempor", "incididunt", "ut", "labore", "et", "dolore", "magna", "aliqua."
            };
            
            //This for loop utilizes a counter to count through each part of Array Sentence
            for (int i = 0; i < Sentence.Length; i++)
            {
                Console.WriteLine("Element[" + i + "] = " + Sentence[i]);//Lists each part of the array
            }

            Console.ReadLine();
        }
    }
}    