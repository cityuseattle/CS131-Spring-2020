using System;

namespace Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            // a starts at 0
            // a is less than or equal to 0
            // increment a number to the variable a until
            // that number reaches 10
            for (int a = 0; a <= 10; a++)
            {
                // display the value of a until 10 is reached in the
                // for loop
                Console.WriteLine(a);
            }

            for (int a = 15; a >= 1; --a)
            {
                Console.WriteLine(a);
            }
        }
    }
}
