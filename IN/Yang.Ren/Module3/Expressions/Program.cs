using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 20;

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
        }
    }
}
