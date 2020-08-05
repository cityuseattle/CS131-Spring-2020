using System;

namespace ScopeLevels
{
    class ScopeLevelsProgram
    {
        static int rawMaterialQuantityForGoods = 100; // class level declaration
        static int rawMaterialQuantityForHeater = 2000;

        public static void ShowRawMaterialQuantity()
        {
            const bool ALWAYS_TRUE = true;
            int rawMaterialQuantityForGoods = 300;
            Console.WriteLine("method scope, rawMaterialQuantityForGoods: " + rawMaterialQuantityForGoods);
            if(ALWAYS_TRUE)
            {
                int rawMaterialQuantityForHeater = 700;
                Console.WriteLine("block scope, rawMaterialQuantityForHeater: " + rawMaterialQuantityForHeater);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("global class scope, rawMaterialQuantityForGoods: " + rawMaterialQuantityForGoods);
            Console.WriteLine("global class scope, rawMaterialQuantityForHeater: " + rawMaterialQuantityForHeater);
            ShowRawMaterialQuantity();
            Console.ReadLine();
        }
    }
}
