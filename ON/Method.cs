using System;

namespace Methods
{
    class Program
    {
        //public static void PrintSomething()
        //{
        //    Console.WriteLine("Hello World!");
        //}

        //static void Main(string[] args)
        //{
        //    //PrintSomething(); // the method PrintSomething is called here
        //}

        //public static int Adding(int num1, int num2)
        //{
        //    int sum = num1 + num2;// the integers are being added
        //    return sum;// the value of sum is to be returned
        //}

        //static void Main(string[] args)// The method is called "Main"
        //{
        //    Console.WriteLine(Adding(10, 20));//The method "Adding" is being called and I gave num1 and num2 values.
        //                                       // the result will be printed when the program is ran.
        //}

        public static int Mod(int a, int b)
        { 
            int modulus = a % b;// initialized the equation that will be ran in the program
            return modulus; // the value of modulus is being returned
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Mod(20, 13));// Gave "a" the value of 20 and "b" the value of 13.
        }
    }
}
