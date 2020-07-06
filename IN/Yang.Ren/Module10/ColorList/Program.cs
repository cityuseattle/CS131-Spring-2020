using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace ColorList
{
    class Program
    {
        public class ColorList
        {
            public string color { get; set;}
        }
        private static void Print(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            List<string> Colors = new List<string>();


            Colors.Add("White");
            Colors.Add("Red");
            Colors.Add("Orange");
            Colors.Add("Yellow");
            Colors.Add("Green");
            Colors.Add("Blue");
            Colors.Add("Indigo");
            Colors.Add("Violet");
            Colors.Add("Black");

            Console.WriteLine("\nColors List\n");

            Colors.Print();

            Console.WriteLine("\nPress <Enter> to sort the Colors list\n");
            Console.ReadLine();
            Colors.Sort();

           int n = Colors.Count();
           Console.WriteLine("\nThe Colors list has{0} items", n);

            foreach (string color in Colors)
            {
                Console.WriteLine(color);
            }

            int index = Colors.IndexOf("Voilet");
            Console.WriteLine("\nIndex of the level is: " + index.ToString());
            Console.WriteLine("Print it out: {0}", Colors[index]);

            Console.WriteLine("\nPress <Enter> to remove 'Violet'\n");
            Console.ReadLine();
            Console.WriteLine("\nRemove Violet");
            Console.WriteLine(Colors[8]);
            Colors.Remove((Colors[8]));

            Console.WriteLine("\nPress <Enter> to add a new item 'purple'\n");
            Console.ReadLine();

            Colors.Insert(0, "purple");
            Console.WriteLine("\nPress <Enter> to see new list\n");
            Console.ReadLine();
            foreach (string color in Colors)
            {
                Console.WriteLine(Colors);
            }
            bool Magenta = Colors.Contains("Nagenta");
                if(Magenta)
            {
                Console.WriteLine("\nThere is  a Magenta in the list");
            }
         

            Colors.Add("Magenta");
            Console.WriteLine("\nPress <Enter> to see new list\n");
            Console.ReadLine();
            foreach (string color in Colors)
            {
                Console.WriteLine(Colors);
            }

        }
    }
}
