using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashTable = new Hashtable() //initialize a hashtable using build in library collections
            {
                {"Kim", 26}, //key = kim; value = 26
                {"John", 77 }, //key = John; value = 77
                {"Max" ,50}, // key = Max; value = 50;
            };
            int HashTableVal1 = (int)myHashTable["Kim"];
            int HashTableVal2 = (int)myHashTable["John"];
            int HashTableVal3 = (int)myHashTable["Max"];

            Console.WriteLine(HashTableVal1);        //print on screen
            Console.WriteLine(HashTableVal2);        //print on screen
            Console.WriteLine(HashTableVal3);           //print on screen
        }

    }
}
