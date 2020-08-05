using System;

namespace Scopes

/********
**
** Name: Cesar, Eugenio
** Class: CS 132
** Project: Scopes
** Date: 2020-08-02
** Description: This program show us how 
*  the method, and class scope works
**
********/


{
    class Program
    {
        // public variable at class scope
        public static string Str2;

        // this method is called ReturnString
        // this method returns a string
         static void ReturnString(string Str1) 
        {
          string Str2 = "Programming in C#";

        Console.Write(Str1);
        Console.WriteLine(Str2);
        }

        // this method call to ReturnString Method
        static void Main(string[] args)
        {
            ReturnString("CS131 "); // call the ReturnString method
            Console.WriteLine(Str2);
        }
    }
}
