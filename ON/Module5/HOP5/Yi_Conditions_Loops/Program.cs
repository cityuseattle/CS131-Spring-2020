using System;

namespace Yi_Conditions_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            
            Console.WriteLine("Guess a number (1-10): ");
            //Receive user input and sore in "userInput" variable
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == num)
            {
                Console.WriteLine("Your guess was correct!");
            }
            //The Secondary rule keeps the guessed numbers under 10
            else if (userInput != num & userInput < 10)
            {
                Console.WriteLine("You guessed wrong. Good luck next time.");
            }
            //Challenge question
            else if (userInput > 10)
            {
                Console.WriteLine("The number must be between 1 and 10.");
            }
        }
    }
}