using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashtable = new Hashtable()
            {
                {"Kim", 26 },
                {"John", 77 },
                {"Max", 50 },
            };

            int HashtableVal1 = (int)myHashtable["Kim"];
            int HashtableVal2 = (int)myHashtable["John"];
            int HashtableVal3 = (int)myHashtable["Max"];

            Console.WriteLine(HashtableVal1);
            Console.WriteLine(HashtableVal2);
            Console.WriteLine(HashtableVal3);
        }
    }
}
