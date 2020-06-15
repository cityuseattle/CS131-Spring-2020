using System;

namespace Swap
{
    class Program
    {
        static void swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("Swapping {0}s", typeof(T));
            Console.WriteLine("Before swap: a = {0}, b = {1}", a, b);

           
                T temp = a;
                a = b;
                b = temp;
                Console.WriteLine("After swap: a = {0}, b = {1}\n", a, b);
        
        }
        static void displayBaseClass<T>()
        {
            Console.WriteLine("Base class of {0} is {1}\n", typeof(T), typeof(T).BaseType);
        }
            static void Main(string[] args)
        {
            displayBaseClass<int>();
            displayBaseClass<string>();
      
            
                int a = 6;
                int b = 16;
                string c = "Hello";
                string d = "world";

                swap<int>(ref a, ref b);
                swap<string>(ref c, ref d);

                bool t = true;
                bool f = false;

                swap(ref t, ref f);
                Console.ReadLine();
            }
        }     

    }

