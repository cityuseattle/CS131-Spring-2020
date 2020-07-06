using System;

namespace ScopeLevel
{
    class Program
    {
        static int Home = 111;
        static int HomeAndMethodLevel = 222;
        static int HomeAndBlockLevel = 333;


        static void Main()
        {
            Console.WriteLine("Home Level " + Home);
            Console.WriteLine("Home Level " + HomeAndMethodLevel);
            Console.WriteLine("Home Level " +HomeAndBlockLevel);
            ShowLocalizedValues();
    
        }
        static void ShowLocalizedValues()
        {
            const bool  ENTER_CONDITION = true;
            int HomeAndMethodLevel = 200;
            Console.WriteLine("Method Level : " + HomeAndMethodLevel);
            if (ENTER_CONDITION)
            {
                int HomeAndBlockLevel = 20;
                Console.WriteLine("Block Level : " + HomeAndBlockLevel);
            }
        }
    }
}
