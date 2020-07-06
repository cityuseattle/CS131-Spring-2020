using System;

namespace CompareString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one word");
            string string1 = Console.ReadLine();

            Console.WriteLine("What is the word2");
            string string2 = Console.ReadLine();

            Console.WriteLine("Are they the same? {0}", string1 == string2);

            bool inoroOut = string1.ToUpper()  == string2.ToUpper();
            if (inoroOut)
                Console.WriteLine("Right");
            else
                Console.WriteLine("False");

            //Console.WriteLine("Are they the same using ToUpper? {0}",  string1.ToUpper() = string2.ToUpper());

            Console.ReadKey();
        }
    }
}
