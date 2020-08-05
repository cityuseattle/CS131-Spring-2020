using System;

/********
**
** Name: Cesar, Eugenio
** Class: CS 132
** Project: Numeric Operators and Routine
** Date: 2020-07-29
** Description: This program has an incremental FOR cycle (from 0 to 10) and stop when a variable gets the 10th iteration. 
*  And then has a decremental FOR cycle (from 15 to 0) and stop when a variable does 15th iteration.
**
********/


namespace Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int a=0; a <= 10; a++) //starting iteration from 0 until 10
            {
                Console.WriteLine(a); //print iterations
            }
          

            for (int a = 15; a >= 0; --a) //starting iteration from 15 to 0
            {
                Console.WriteLine(a); //print iterations
             
            } 

        }
    }
}
