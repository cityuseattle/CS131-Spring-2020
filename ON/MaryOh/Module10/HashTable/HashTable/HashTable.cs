using System;
using System.Collections;

namespace HashTable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Initialize hash table using built in library collections
            Hashtable myHashTable = new Hashtable()
            {
                // key, value pairs
                {"Kim", 26 },
                {"John", 77 },
                {"Max", 50 }
            };

            // Obtaining values of keys
            int HashTableVal1 = (int)myHashTable["Kim"];
            int HashTableVal2 = (int)myHashTable["John"];
            int HashTableVal3 = (int)myHashTable["Max"];

            Console.WriteLine(HashTableVal1);
            Console.WriteLine(HashTableVal2);
            Console.WriteLine(HashTableVal3);
        }
    }
}
