using System;

namespace Yi_GoQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obligatory statement about utilizing narrative that is quoted
            Console.WriteLine("The following dialog is from The Matrix (The First Movie)");
            Console.WriteLine("The ending statement when you quit is from Matrix the Game");
            Console.WriteLine("The references are listed at the bottom of the code, commented.");
            Console.WriteLine("Do you want to proceed? (Y/N)");

            bool response = true;

            while (response)
            {
                string Answer = Console.ReadLine();
                if (Answer == "Y" || Answer == "y") //checks the response of the user if they want to proceed.
                {
                    Console.WriteLine("Excellent. Let's proceed.");
                    ShowMenu();
                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("I'm sorry you won't be joining us.");
                        Environment.Exit(0);//This code exits the program
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Follow me.");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("I'm sorry you won't be joining us.");
                    Environment.Exit(0);
                }
            }
        }

        //Shows the menu 
        static void ShowMenu()
        {
            //The actual menu. Blue pill means stop, Red pill means go.
            Console.WriteLine("**This is your last chance. After this there is no turning back.**");
            Console.WriteLine("1. You take the blue pill, the story ends; you wake up " +
                              "in bed and believe whatever you want to believe.");
            Console.WriteLine("2. You take the red pill, you stay in Wonderland " +
                              "and I show you how deep the rabbit hole goes. " +
                              "Remember, all I'm offering is the truth. Nothing more. ");
        }
    }
}

/* Citations follow:
 * 
 * Matrix. (1999)
 *
 * The Matrix, Path of Neo, Shiny Entertainment. (2005)
*/