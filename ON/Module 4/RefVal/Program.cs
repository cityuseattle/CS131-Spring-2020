using System;

namespace RefVal
{
    class Program
    {
        static void Main()
        {
            float cog = 21.5f;
            float labor = 75000.0f;
            // ecplicitly pass variables by reference
            AdjustForInflation(ref cog, ref labor);
            Console.WriteLine("** Costs After Seattle Tax Adjustment **");
            Console.WriteLine("Costs Of Goods:   " + cog);
            Console.WriteLine("ALL Labor:  " + labor);
            Console.ReadLine();
        }
        static void AdjustForInflation(ref float cog, ref float labor)
        {
            const float RATE = 1.61f;
            cog *= RATE;
            labor *= RATE;
        }

    }
}
