using System;
using System.Xml.Schema;

namespace TimeSpan3
{
    class Program
    {
        static void Main(string[] args)
        {
            int PRGM = 10, TEST = 5;

            TimeSpan tsA = new TimeSpan(PRGM);  //10 hours
            TimeSpan tsB = new TimeSpan(TEST);  //5 hours
            TimeSpan tsC = tsA + tsB;            // returns 15 hours
            Console.WriteLine("total development time:" + tsC + "  hours");
            int comparison = tsA.CompareTo(tsB);
            if (comparison > 0)
                Console.WriteLine("Programming took longer:");
            else if (comparison < 0)
                Console.WriteLine("Testing took Longer");

            Console.ReadLine();


        
        }
    }
}
