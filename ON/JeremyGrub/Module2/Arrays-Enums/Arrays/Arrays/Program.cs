using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = new string[4]; //creating a new array of type integer named 'sentence'
            sentence[0] = "This";
            sentence[1] = "is";
            sentence[2] = "a";
            sentence[3] = "string";
          

            //print out the whole array
            //for (string i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            foreach (string number in sentence)
            {
                Console.Write(sentence + " ");
            }
        }
    }
}
