using System;

namespace CompareString
{
    class CompareStringProgram
    {
        public static bool comparisonIgnoreCase (string string1, string string2)     //Method declaration
        {
            string string1Lower = string1.ToLower();
            string string2Lower = string2.ToLower();
            bool isMatch = string1Lower.Equals(string2Lower);
            return isMatch; 
         }
        static void Main(string[] args)
        {
            string name1 = "Hello";                //variable string declared
            string name2 = "hello";                //variable string declared
            string fruit1 = "apple";               //variable string declared
            string fruit2 = "mango";               //variable string declared
            Console.WriteLine($"Comparing {name1} and {name2} and result is: " +  comparisonIgnoreCase(name1, name2));   //Displaying result of comparing string and ignoring case
            Console.WriteLine($"Comparing {fruit1} and {fruit2} and result is: " + comparisonIgnoreCase(fruit1, fruit2)); //Displaying result of comparing string and ignoring case
        }
    }
}
