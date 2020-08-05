using System;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrList = new ArrayList();           // Created Array List using built in library

            myArrList.Add(10);                              //Added value to Array List using Add() method
            myArrList.Add(11.5);
            myArrList.Add("This is a string");

            myArrList.AddRange(new ArrayList() {20,17.7,"This is another string" }); //Added value to Array list using AddRange() method.

            myArrList.Remove(10);                         //removed array list elements 
            myArrList.RemoveAt(0);                        //removed array list elements
            myArrList.RemoveRange(1, 2);                 //removed array list elements

            foreach (var value in myArrList)              //print each value in the array list using foreach() function
            {
                Console.WriteLine(value);
            }
        }

    }
}
