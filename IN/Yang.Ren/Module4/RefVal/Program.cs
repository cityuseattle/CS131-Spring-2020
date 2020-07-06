using System;

namespace RefVal
{
    class Program
    {
        static void Main()
        {
            float Price1 = 100000.0f;
            float Price2 = 200000.0f;

            PriceAfterDiscount(ref Price1, ref Price2);
            Console.WriteLine(" ** Price after Discount ** ");
            Console.WriteLine("Sheos : " + Price1);
            Console.WriteLine("Clothes : " + Price2);
           // Console.ReadLine;
        }

        static void PriceAfterDiscount(ref float Price1, ref float Price2)
        {
            const float DISCOUNT = 0.8f;
            Price1 *= DISCOUNT;
            Price2 *= DISCOUNT;
        }
    }
}
