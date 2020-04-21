using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //set variables
            int score = 77;
            string total = "Value 100";
            float num = 22.25f;
            int numbers = (int)num; //casting float to int
            
            //write variables out
            Console.WriteLine(score);
            Console.WriteLine(total);
            Console.WriteLine(num);
            Console.WriteLine(numbers);
        }
    }
}