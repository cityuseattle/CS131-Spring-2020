using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace Yi_ColorList
{
    class Program
    {
        private static void ColorPrint(string s) //Creates a method called to print The colors in the list
        {
            Console.WriteLine(s);
        }
        
        static void Main(string[] args)
        {
            List<string> ColorsList = new List<string>();//Creates the list
            ColorsList.Add("White");
            ColorsList.Add("Red");
            ColorsList.Add("Orange");
            ColorsList.Add("Yellow");
            ColorsList.Add("Green");
            ColorsList.Add("Blue");
            ColorsList.Add("Indigo");
            ColorsList.Add("Violet");
            ColorsList.Add("Black");

            Console.WriteLine("The color list is:");//First iteration of printing the list
            foreach (string color in ColorsList)
            {
                ColorPrint(color);
            }
            Console.WriteLine();
            
            //Locates, removes and changes the list based on the index of the color Violet
            int index = ColorsList.IndexOf("Violet");
            ColorsList.RemoveAt(index);
            ColorsList.Insert(index,"Purple");
            
            Console.WriteLine("The new color list is:");//Second iteration of printing the list
            foreach (string color in ColorsList)
            {
                ColorPrint(color);
            }
            Console.WriteLine($"with the color Violet replaced with Purple" +
                              $" at position {index+1} in the list.");
            Console.WriteLine();

            //Check for Magenta
            if (ColorsList.Contains("Magenta"))
            {
                Console.WriteLine("Magenta is in the list.");
            }
            else ColorsList.Add("Magenta");//Adds magenta into the color list
            
            if (ColorsList.Contains("Magenta"))
            {
                int idx = ColorsList.IndexOf("Magenta");
                Console.WriteLine($"Magenta is in the list at position: {idx + 1}.");
            }
            foreach (string color in ColorsList)//Last iteration of printing the list
            {
                ColorPrint(color);
            }
            Console.WriteLine();
        }
    }
}