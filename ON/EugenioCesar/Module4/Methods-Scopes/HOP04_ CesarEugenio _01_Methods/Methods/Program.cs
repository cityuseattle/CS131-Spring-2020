using System;

namespace Methods

/********
**
** Name: Cesar, Eugenio
** Class: CS 132
** Project: Modulus
** Date: 2020-08-01
** Description: This program finds the modulus 
*  of a number divided by another
**
********/


{
    class Program
    { 
        //this is a method called "Mod"
        //it function is to find the modulus of a divided by b
        public static int Mod(int a, int b)
        {
            int module = a % b;
            return module;
        }

        //this method is called "Mod"
        //this method is called when the program is ran
        static void Main(string[] args)
        {
            Console.WriteLine(Mod(20, 13));  //method "Mod" is called here
        }
    }
}
