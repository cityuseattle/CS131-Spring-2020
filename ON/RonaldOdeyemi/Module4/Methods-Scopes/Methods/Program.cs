using System;

namespace Methods
{
    class Program
    {
        
        public static int Mod(int a, int b)

        {
            int Modulus = a%b;
            return Modulus;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Mod(20,13));
        }
    }
}
