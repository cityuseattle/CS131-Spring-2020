using System;

namespace Conditions_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("Guess a number (1 - 10): ");
            //receive user input and store in "userInput" variable
            //convert user input to integer type
            int userInput = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (userInput > 0 && userInput <= 10)
                {
                    if (userInput == num)
                    {
                        Console.WriteLine("Your guess was correct!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You guessed wrong. Guess again: ");
                        userInput = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else if (userInput < 0 || userInput > 10)
                {
                    Console.WriteLine("Number must be between 1 - 10. Guess again: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
