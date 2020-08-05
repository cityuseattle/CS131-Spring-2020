using System;

namespace Expressions
{
    class ExpressionsProgram
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 20;
            Console.WriteLine ("Sum: {0} + {1} = {2}", a, b, a + b);
            Console.WriteLine ("Subtract: {0} - {1} = {2}", a, b, a - b);
            Console.WriteLine ("Multiply: {0} * {1} = {2}", a, b, a * b);
            Console.WriteLine ("Divide: {0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("Remainder: {0} % {1} = {2}", a, b, a % b);
        }
    }
}
