using System;

namespace Methods
{
    class Program
    {
        public static int Remainder(int num1, int num2)
        {
            int modulus = num1 % num2;
            return modulus;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Remainder(20,13));
        }
    }
}
