using System;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            Console.WriteLine("Guess a number (1 - 10): ");
            int userInput = Convert.ToInt32(Console.ReadLine()); //receive user input and store in "userInput" variable

            while (userInput > 0 && userInput <= 10)
                {
                    if (userInput == num)
                    {
                        Console.WriteLine("Your Guess was Correct!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You Guessed Wrong, Guess Again:");
                        userInput = Convert.ToInt32(Console.ReadLine());
                    if (userInput >= 11)
                        Console.WriteLine("Number must be between 1 and 10, Guess Again!");
                    userInput = Convert.ToInt32(Console.ReadLine());

                }
            }
        }
    }
}
