using System;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //create Array list using built in library
            ArrayList myArrList = new ArrayList();

            //Add values to Array List using Add() method
            myArrList.Add(10);
            myArrList.Add(11.5);
            myArrList.Add("This is a string");

            //add values to array list using AddRange() method
            myArrList.AddRange(new ArrayList() { 20, 17.7, "this is another string" });

            //remove array list elements using RemoveRange() and RemoveAt() and remove () methods
            myArrList.Remove(10);

            myArrList.RemoveAt(0);

            myArrList.RemoveRange(1, 2);

            //print each value in the array list using foreach() method
            foreach(var value in myArrList)
            {
                Console.WriteLine(value);
            }
        }
    }
}
