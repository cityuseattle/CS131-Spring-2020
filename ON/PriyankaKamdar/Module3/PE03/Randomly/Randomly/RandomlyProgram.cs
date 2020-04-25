using System;

namespace Randomly
{
    class RandomlyProgram
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int a = rnd.Next(1, 100);
            int b = rnd.Next(1, 100);

            Console.WriteLine("Value of a: {0}", a);
            Console.WriteLine("Value of b: {0}", b);
            Console.WriteLine("Sum: {0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("Subtract: {0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("Multiply: {0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("Divide: {0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("Remainder: {0} % {1} = {2}", a, b, a % b);          
        }
    }
}
