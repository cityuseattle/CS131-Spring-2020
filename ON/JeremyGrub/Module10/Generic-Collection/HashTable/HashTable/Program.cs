using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashtbale = new Hashtable() //initialize a hash tbale using build in library Collections
            {
                {"Kim", 26}, //key = Kim; value = 26
                {"John", 77}, //key = John; value = 77
                {"Max", 50} //key = Max; value = 50
            };

            int HashTableVal1 = (int)myHashtbale["Kim"]; //get value of Kim and store it in HashTableVal1
            int HashTableVal2 = (int)myHashtbale["John"]; //get value of John and store it in HashtTableVal2
            int HashTableVal3 = (int)myHashtbale["Max"]; // get value of Max and store it in HashTableVal3
            
            //print on screen
            Console.WriteLine(HashTableVal1);
            Console.WriteLine(HashTableVal2);
            Console.WriteLine(HashTableVal3);
        }
    }
}
