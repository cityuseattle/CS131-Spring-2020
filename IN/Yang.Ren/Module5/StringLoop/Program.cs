using System;

namespace StringLoop
{
    class Program
    {
        static void Main()
        {
            string[] letters = new string[] { "w", "o", "r", "d" };
            Console.WriteLine("the array is 'word'!");
            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine("Element [" + i + "] = " + letters[i]);
            }
            Console.ReadLine();
        }
    }
}
