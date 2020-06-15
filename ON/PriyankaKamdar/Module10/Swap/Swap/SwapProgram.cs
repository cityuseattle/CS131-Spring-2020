using System;

namespace Swap
{
    class SwapProgram
    {

        static void Swap<T> (ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

        }
        static void Main(string[] args)
        {
            int intValue1 = 5, intValue2 = 10;
            string strValue1 = "class", strValue2 = "room";

            Console.WriteLine("Int values before swap: intValue1: {0}, intValue2: {1} ",  intValue1,  intValue2);
            Swap<int>(ref intValue1, ref intValue2);
            Console.WriteLine("Int values after swap: intValue1: {0}, intValue2: {1} ", intValue1, intValue2);

            Console.WriteLine("String values before swap: strValue1: {0}, strValue2: {1} ", strValue1, strValue2);
            Swap<string>(ref strValue1, ref strValue2);
            Console.WriteLine("String values after swap: strValue1: {0}, strValue2: {1} ", strValue1, strValue2);
        }
    }
}
