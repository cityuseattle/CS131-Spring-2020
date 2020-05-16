using System;

namespace Yi_NumOut
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 987654.321d; //establish the variable double num

            //changes num to string and makes it have 2 decimals
            string str1 = num.ToString("F2"); //F2 creates a fixed 2 decimal formatting
            Console.WriteLine(str1);
            
            //changes num to string and rounds it to an int
            string str2 = num.ToString("0"); //0 creates just an integer with no decimal
            Console.WriteLine(str2);
            
            //Changes num to string and changes it to currency form
            string str3 = num.ToString("C"); //C swaps to local currency
            Console.WriteLine(str3);
        }
    }
}