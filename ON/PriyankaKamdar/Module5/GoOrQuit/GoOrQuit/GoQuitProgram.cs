using System;

namespace GoOrQuit
{
    class GoQuitProgram
    {
         public static void Main()
         {
            bool readInput = true;

            while (readInput)
            {
                ShowRestaurantMenu();
                string option = Console.ReadLine();
                if (option == "1") 
                { 
                
                    Console.WriteLine("You have selected Pizza.");
                }
                else if (option == "2")
                { 
                    Console.WriteLine("You have selected Burger.");
                }
                else if (option == "3")
                {
                    Console.WriteLine(" You have selected to Quit.");
                    break;
                }
                else 
                {
                    Console.WriteLine("You have not selected a valid option.");
                }
            }
         }
    public static void ShowRestaurantMenu()
        {
            //show restaurant Menu.
            Console.WriteLine("**Menu**");
            Console.WriteLine("1. Pizza");
            Console.WriteLine("2. Burger");
            Console.WriteLine("3. Quit");
        }
    }
}
