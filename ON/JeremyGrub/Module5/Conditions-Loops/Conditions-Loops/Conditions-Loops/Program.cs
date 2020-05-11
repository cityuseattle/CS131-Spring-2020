using System;

namespace Conditions_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            Console.WriteLine("Guess a number (1-10): ");
            int userInput = Convert.ToInt32(Console.ReadLine()); //receive user input and store in "userInput variable

            if (userInput == num)
            {
                Console.WriteLine("Your guess was correct!");
            }
            else if (userInput > 10)
            {
                Console.WriteLine("Number must be inbetween 1-10!!!");
            }

            else if (userInput != num)
            {
                Console.WriteLine("You guessed wrong. Goodluck next time!");
            }

        }
    }
}
