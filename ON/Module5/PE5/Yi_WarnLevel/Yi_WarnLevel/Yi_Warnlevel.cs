using System;

namespace Yi_WarnLevel
{
    class Program
    {
        /**This first code was how I originally started working on the code. But then I thought,
        I could automate the warning levels, if all we were doing was displaying each level
        and it's corresponding messages
        
        Create Constant Integers of the warning levels
        const int NoEmerg = -1;
        const int LVL0 = 0, LVL1 = 1, LVL2 = 2, LVL3 = 3;
        
        static void Main(string[] args)
        {
            int Level = NoEmerg;
            WarningType(Level);

            Level = LVL0;
            WarningType(Level);

            Level = LVL1;
            WarningType(Level);
            
            Level = LVL2;
            WarningType(Level);

            Level = LVL3;
            WarningType(Level);
        }
        //This method lists all of the levels and their warning types.
        public static void WarningType(int Level)
        {
            if (Level == LVL3)
            {
                Console.WriteLine("Warning! Evacuate now! Hurricane is closing in!");
            }
            else if (Level == LVL2)
            {
                Console.WriteLine("Warning! Prepare for evacuation. Hurricane imminent!");
            }
            else if (Level == LVL1)
            {
                Console.WriteLine("Warning! Hurricane is developing over the ocean");
            }
            else if (Level == LVL0)
            {
                Console.WriteLine("Storm is developing over the ocean. We are monitoring the situation.");
            }
            else
            {
                Console.WriteLine("No issues detected. Enjoy your day!");
            }
        }**/
        
        //This starts the new version of the program with the levels automated in a for loop.
        
        //I had to make the int[] array static so that it could be utilized in the Main()
        
        static int[] warnlvl = {0,1,2,3,4};

        static void Main(string[] args)
        {
            for (int i = 0; i <= warnlvl.Length; i++)
            {
                int Level = i;
                WarningType(Level);
            }
        }

        
        //This method lists all of the levels and their warning types.
        public static void WarningType(int Level)
        {
            if (Level == 4)
            {
                Console.WriteLine("Warning! Evacuate now! Hurricane is closing in!");
            }
            else if (Level == 3)
            {
                Console.WriteLine("Warning! Prepare for evacuation. Hurricane imminent!");
            }
            else if (Level == 2)
            {
                Console.WriteLine("Warning! Hurricane is developing over the ocean");
            }
            else if (Level == 1)
            {
                Console.WriteLine("Storm is developing over the ocean. We are monitoring the situation.");
            }
            else
            {
                Console.WriteLine("No issues detected. Enjoy your day!");
            }
        }
    }
}