using System;

namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Toppings = 3;
            const int PEPPERONI = 0;
            const int SAUSAGE = 1;
            const int MUSHROOM = 2;
            
            //Part A: Assigning size in the declaration
            string[] name = new string[Toppings];
            name[PEPPERONI] = "Pepperoni";
            name[MUSHROOM] = "Mushroom";
            name[SAUSAGE] = "Sausage";
            
            //Part B: Assigning size
            int[] numToppings;
            numToppings = new int[Toppings];
            numToppings[PEPPERONI] = 15;
            numToppings[MUSHROOM] = 20;
            numToppings[SAUSAGE] = 30;
            
            //part C: Initialize the Array and size in the declaration
            float[] diameter = new float[] {10.3f, 12.1f, 1.75f};

            int topping = PEPPERONI;
            Console.WriteLine(" * Statistics for " + name[topping] + " *");
            Console.WriteLine("Number of Toppings: " + numToppings[topping]);
            Console.WriteLine("Diameter of Toppings: " + diameter[topping]);

            Console.ReadLine();
        }
    }
}