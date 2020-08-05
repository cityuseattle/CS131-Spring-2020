using System;

namespace Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 15; a >= 1; a--) //Initially variable "a" is defined with value 15. At end of each iteration value of "a" is decrement by 1 until value of "a" becomes less than 1.  
            {
                Console.WriteLine(a);
            }

        }
    }
}
