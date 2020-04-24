using System;

namespace Yi_Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //For loops to list 0-10, increasing by 1
            for (int a = 0; a <= 10; a++)
            {
                Console.WriteLine(a);
            }
            
            Console.WriteLine("");
            
            //For loops to list 15-1, decreasing by 1
            for (int a = 15; a > 0; a--)
            {
                Console.WriteLine(a);
            }
        }
    }
}