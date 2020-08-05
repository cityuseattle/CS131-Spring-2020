using System;

namespace BinaryOperators
{
    class BinaryOperatorsProgram
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 20;

            a += b;
            Console.WriteLine ("Sum of value of a is: {0} ",a);

            a -= b;
            Console.WriteLine ("Subtract value of a is: {0}",a);

            a *= b;
            Console.WriteLine ("Multiply value of a is: {0}",a);

            a /= b;
            Console.WriteLine ("Divide value of a is: {0}", a);

            a %= b;
            Console.WriteLine ("Remainder value of a is: {0}",a);
        }
    }
}
