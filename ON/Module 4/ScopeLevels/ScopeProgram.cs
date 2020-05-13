using System;

namespace ScopeLevels
{
    class Program
    {
        static int classAndMethodLevel = 100; //Class level declaration
        static int classAndBlockLevel = 200; 
        static void Main(){
            Console.WriteLine("Class Level: " + classAndMethodLevel);
            Console.WriteLine("Class Level: " + classAndBlockLevel);
            ShowLocalizedValues();
            Console.ReadLine();
        }
        //Receive uninitialized interest rate explicitly by reference.
        static void ShowLocalizedValues()
        {
            const bool ENTER_CONDITION = true;
            int classAndMethodLevel = 25; //method level declaration.
            Console.WriteLine("Method Level: " + classAndMethodLevel);
            if (ENTER_CONDITION)
            {
                int classAndBlockLevel = 5; //block level declaration
                Console.WriteLine("Block Level: " + classAndBlockLevel);

            }
        }
    }
}
