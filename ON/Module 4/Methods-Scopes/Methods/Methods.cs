using System;

namespace Methods
{
    class Program
    {
        //this is a method called Mod that takes in 2 parameters
        //both of type integer
        public static int Mod(int num1, int num2)
        {
            //the passed in integers are added
            //and the result is stored in the integer "sum"
            int modulus = num1 % num2;
            return modulus; //return the value stored in "sum"
        }

        //this is a method called "Main",
        //this method is called when the program is ran
        static void Main(string[] args)
        {
            //call method "Adding" and pass in 2 parameters: 10 and 20
            //and print the result of method "Adding"
            Console.WriteLine(Mod(20, 13));
        }
    }
}
