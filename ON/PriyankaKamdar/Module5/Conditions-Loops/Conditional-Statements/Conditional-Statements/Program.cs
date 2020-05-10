using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            Console.WriteLine("Guess a number (1 - 10): ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == num)
            {
                Console.WriteLine("Your guess was correct!");
            }
            else if (userInput > 10)
            {
                Console.WriteLine("Number must be between 1 - 10!!!");
            }
            else if (userInput != num)
            {
                Console.WriteLine("You guessed wrong, Goodluck next time!");
            } 
        }
    }
}

