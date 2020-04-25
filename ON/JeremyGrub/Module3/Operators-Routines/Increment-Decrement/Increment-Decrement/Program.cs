using System;

namespace Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int a = 15; a >= 1; a--)         //a starts at 0, then is set to <=10, then is looped in increments of 1 up to 10
            {
                Console.WriteLine(a);         
            }
        }
    }
}
