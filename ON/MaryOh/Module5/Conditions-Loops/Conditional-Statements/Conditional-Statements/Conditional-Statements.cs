using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            Console.WriteLine("Guess a number (1-10): ");
            // Receives user input and stores as userInput
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Conditional statement to check if number is within range
            if (1 <= userInput && userInput <= 10)
            {
                // Conditional statement to check if userInput matches num
                if (userInput == num)
                {
                    Console.WriteLine("Your guess was correct!");
                }

                // Conditional statement to check if userInput not equal to num
                else if (userInput != num)
                {
                    Console.WriteLine("You guessed wrong. Good luck next time!");
                }
            }

            else
            {
                Console.WriteLine("Number must be between 1 and 10!");
            }
        }
    }
}
