using System;

namespace Methods
{
    class Methods
    {
        //// this is a method called "PrintSomething"
        //// its function is to print a line of string "Hello World!"
        //public static void PrintSomething() {
        //    Console.WriteLine("Hello World!");
        //}

        //// this is a method called "Main"
        //// this method is called when the program is ran
        //static void Main(string[] args)
        //{
        //    PrintSomething(); // mmethod "PrintSomething" is called
        //}

        //// this is a method called Adding that takes in 2 parameters
        //// both of type integer
        //public static int Adding(int num1, int num2)
        //{
        //    // the passed in integers are added
        //    // and the result is stored in the integer sum
        //    int sum = num1 + num2;
        //    return sum; // return the value stored in sum
        //}

        //// this is a method called "Main"
        //// this method is called when the program is ran
        //static void Main(string[] args)
        //{
            //// call method Adding and pass in 2 parameters: 10 and 20
            //// print the result of method Adding
            //Console.WriteLine(Adding(10, 20));
        //}

        // initializing method called Mod to calculate modulus of a/b
        public static int Mod(int a, int b) {
            int modulus = a % b;
            return modulus;
        }

        static void Main(string[] args) {
            //calling method Mod and passing parameters a = 20 and b = 13
            Console.WriteLine(Mod(20, 13));
        }
    }
}
