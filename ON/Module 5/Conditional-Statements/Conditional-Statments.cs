using System;

namespace Conditions_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("Guess a numer (1 - 10): ");
            //receive user input and store in "userInput" variable
            //convert user input to integer type
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == num)
            {
                Console.WriteLine("your guess was correct!");
            }
            else if (userInput > 10)
            {
                Console.WriteLine("Number must be between 1 - 10!!!");
            }
            else if (userInput != num)
            {
                Console.WriteLine("You guessed wrong. Goodluck next time!");
            }
        }
    }
}
