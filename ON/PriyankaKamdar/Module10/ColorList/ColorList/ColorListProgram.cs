using System;
using System.Collections.Generic;
using System.Threading;

namespace ColorList
{
    class ColorListProgram
    {
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
            
            Colors.ForEach(Print); //Print elements of List using ForEach.
            int listSize = Colors.Count; //Returns no of elements in Colors list.
            Console.WriteLine("The Colors list has {0} items", listSize);
            Colors.Sort(); //Sort list.
            Console.WriteLine("Sorted list: ");
            foreach (string color in Colors)
            {
                Console.WriteLine(color);
            }
            int index = Colors.IndexOf("Violet");
            Console.WriteLine("Index of violet: {0}", index);
            Colors.RemoveAt(index); //Remove element at specified index.
            Colors.Insert(Colors.Count - 1, "Purple"); //Insert purple at second last location in list
            Console.WriteLine("Modified list after adding purple");
            foreach (string color in Colors) //Print elements in list using foreach loop.
            {
                Console.WriteLine(color);
            }

            if (Colors.Contains("Magenta")) //Check if list contains Magenta.
            {
                Console.WriteLine("Magenta is in the list first check.");
            }
            else
            {
                Console.WriteLine("Magenta is not in first list check.");
            }
            //Add method add list element at end of te list. 
            //While insert method adds element at specified index provided as input parameter.
            Colors.Add("Magenta"); //Add magneta in list.
            if (Colors.Contains("Magenta"))
            {
                Console.WriteLine("Magenta is in the list second check.");
            }
            else
            {
                Console.WriteLine("Magenta is not in second list check.");
            }

            Console.WriteLine("Modified list after adding Magenta:");

            foreach (string color in Colors)
            {
                Console.WriteLine(color);
            }
        }

    }
}
