using System;

namespace Methods
{
    class Program
    {
        public static int Mod(int a, int b)
        {
            int module = a % b;
            return module;
        }  
        static void Main(string[] args)
        {
            Console.WriteLine(Mod(20,13));
        }
    }
}
