using System;

namespace NumOut
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 987654.321d;
            //integer
            //string Integer = i.ToString("F0");
            //string Decimal = i.ToString("F2");
            string Current = i.ToString("C");
            Console.WriteLine(Current);
        }
    }
}
