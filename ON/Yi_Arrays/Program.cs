using System;

namespace Yi_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5]; //creating a new array of type integer named "numbers"
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            /*print out the whole array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }*/

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            string[] sentences = new string[4]; //Creates a string array
            sentences[0] = "This";
            sentences[1] = "is";
            sentences[2] = "a";
            sentences[3] = "string";

            foreach (string sentence in sentences)
            {
                Console.Write(sentence + " ");
            }
        }
    }
}