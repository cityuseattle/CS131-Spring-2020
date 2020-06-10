using System;

namespace Methods
{
    class Program
    {
        public static int Adding(int num1, int num2)
        {
            int sum = num1 + num2;
           return sum;

       }
        //Challenge
        public static int Mod(int a, int b)
        {
            int modulus = a - b;
            return modulus;
        }

        static void Main(string[] args)
        {
          Console.WriteLine(Adding(10,20));
            Console.WriteLine(Mod(20, 13));
        }
    }
}
