using System;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 9;

            Console.WriteLine("Guess a numebr (1-10): ");
            int userInput = Convert.ToInt32(Console.ReadLine()); //receive user input and store in "userInput" variable

            while(true)
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
                else
                {
                    Console.WriteLine("Number must be between 1-10. Guess again: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }

            }
           
        }
    }
}
