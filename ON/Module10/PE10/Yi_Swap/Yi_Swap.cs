using System;
using System.Collections;

namespace Yi_Swap
{
    class Program
    {
        static void swap<T>(ref T a, ref T b)//Creates the swap method
        {
            T temp = a;
            a = b;
            b = temp; 
        }
        static void Main(string[] args)
        {
            //Establishing Variables
            int a = 8241;
            int b = 9534;
            string i = "cat";
            string j = "dog";
            
            //Body of code that calls swap of integers
            Console.WriteLine($"Integer a before swap: {a}");
            Console.WriteLine($"Integer b before swap: {b}");
            swap(ref a, ref b); //swapping a and b
            Console.WriteLine($"Integer a after swap: {a}");
            Console.WriteLine($"Integer b after swap: {b}\n");
            
            //Body of code that calls swap of strings
            Console.WriteLine($"String i before swap: {i}");
            Console.WriteLine($"Integer j before swap: {j}");
            swap(ref i, ref j); //swapping i and j
            Console.WriteLine($"Integer i after swap: {i}");
            Console.WriteLine($"Integer j after swap: {j}");
        }
    }
}