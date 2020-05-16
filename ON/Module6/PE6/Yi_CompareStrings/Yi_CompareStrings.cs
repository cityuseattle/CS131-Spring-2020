using System;

namespace Yi_CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, let's compare two strings!");
            Console.WriteLine("Type your first string: "); 
            string input1 = Console.ReadLine();//Receives input for first string
            string ip1 = input1.ToLower();//Converts string to lower case
            
            Console.WriteLine("Type your second string: ");
            string input2 = Console.ReadLine();//Receives input for second string
            string ip2 = input2.ToLower();//Converts string to lower case

            String.Equals(ip1, ip2);
            
            Console.WriteLine($"The two inputted strings are: {input1} and {input2}");
            Console.WriteLine($"The inputted strings are equal: {ip1.Equals(ip2)} ");
        }
    }
    
}