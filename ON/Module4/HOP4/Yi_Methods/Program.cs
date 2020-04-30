using System;

namespace Yi_Methods
{
    class Program
    {
        //this is a method called "Adding" that takes in 2 parameters
        //both of type integer
        public static int Adding(int num1, int num2)
        {
            //the passed in integers are added
            //and the result is stored in the integer "sum"
            int sum = num1 + num2;
            return sum; //return the value stored in "sum"
        }
        
        //This method is called "Mod"
        //Both parameters are integers
        public static int Mod(int num3, int num4)
        {
            int mod = num3 % num4;
            return mod;
        }
        
        
        //This is a method called "Main"
        //This method is called when the program is ran
        static void Main(string[] args)
        {
            //Call method "Adding" and pass in 2 parameters: 10 and 20
            //and print the result of method "Adding"
            Console.WriteLine(Adding(10,20));
            
            //Call method Mod, pass 2 parameters, and print result
            Console.WriteLine(Mod(20,13));
        }
    }
}