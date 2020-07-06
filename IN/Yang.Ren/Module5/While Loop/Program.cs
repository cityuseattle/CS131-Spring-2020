using System;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("Guess a number (1 - 10); ");
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

                     if (userInput != num)
                    {
                        Console.WriteLine("Your guessed wrong. Guess again: ");
                        userInput = Convert.ToInt32(Console.ReadLine());
                    }

                     if (userInput > 10)

                    {
                      //  Console.WriteLine("Your guessed wrong. Guess again: ");
                       // Console.WriteLine("Number must be between 1 - 10. Guess again: ");
                    }
                }
               else {
                   Console.WriteLine("Number must be between 1 - 10. Guess again: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
