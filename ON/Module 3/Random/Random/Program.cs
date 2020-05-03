using System;

namespace Random
{
    class Program {

        static Random rnd = new Random();

        static void Main() { 
        
            const int MIN = 10; const int MAX = 25;
            Console.WriteLine("0   <= num < 2,147,483,647: " + rnd.Next());
            Console.WriteLine("0   <= num < 25:            " + rnd.Next(MAX));
            Console.WriteLine("10  <= num < 25:            " + rnd.Next(MIN, MAX));
            Console.WriteLine("0.0 <= num < 1.0:           " + rnd.Next.Double());
            Console.ReadLine();

        }
    }
}
