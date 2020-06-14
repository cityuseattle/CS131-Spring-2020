using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashTable = new Hashtable() //initialize a hash table using build library Collection
            {
                {"Kim", 26}, //key = Kim; value = 26
                {"John", 77}, //key = John; value = 77
                {"Max", 50} //key = Max; value = 50
            };

            int HashTableVal1 = (int)myHashTable["Kim"]; //get the value of key "Kim", store in HashTableVal1
            int HashTableVal2 = (int)myHashTable["John"]; //get the value of key "John", store in HashTableVal2
            int HashTableVal3 = (int)myHashTable["Max"]; //get the value of key "Max", store in HashTableVal3

            Console.WriteLine(HashTableVal1); //print on screen
            Console.WriteLine(HashTableVal2); //print on screen
            Console.WriteLine(HashTableVal3); //print on screen
        }
    }
}
