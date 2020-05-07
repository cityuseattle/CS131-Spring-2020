using System;

namespace Yi_Warnlvl_Bool
{
    class Program
    {
        //Create Constant Integers of the warning levels
        const int NoEmerg = -1;
        const int LVL0 = 0, LVL1 = 1, LVL2 = 2, LVL3 = 3; //Identifies the levels of risk
        const bool Warning = true; //Anything other than noEmerg has a true warning type
        
        static void Main(string[] args)
        {
            /*The Structure for the blocks of code in the Main is as follows:
             * Warning Level type
             * rainIndex
             * Call RainStorm method (Displays how much rain is expected)
             * Call WarningType method (Displays the severity of the incoming hurricane)
             */
            
            int Level = NoEmerg;
            int rainIndex = 3; //All rainIndex is in cm/hr
            RainStorm(rainIndex, !Warning);
            WarningType(Level);

            Level = LVL0;
            rainIndex = 3;
            RainStorm(rainIndex, Warning);
            WarningType(Level);

            Level = LVL1;
            rainIndex = 7;
            RainStorm(rainIndex, Warning);
            WarningType(Level);
            
            Level = LVL2;
            rainIndex = 20;
            RainStorm(rainIndex, Warning);
            WarningType(Level);

            Level = LVL3;
            rainIndex = 60;
            RainStorm(rainIndex, Warning);
            WarningType(Level);
        }
        //This method lists all of the levels and their warning types.
        public static void WarningType(int Level)
        {
            if (Level == LVL3) // Checks for the Level type
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
        }
        
        //This method is the Boolean section.
        //This method reads the rain index and displays the message
        static public void RainStorm(int rainIndex, bool Warning)
        {
            Console.WriteLine("Rain Index: " + rainIndex + " cm/hr."); //States the rain index level
            
            if (rainIndex < 5 && !Warning) //Checks for parameters to display certain messages.
            {
                Console.WriteLine("Light sprinkles expected.");
            }
            else if (rainIndex < 5 && Warning)
            {
                Console.WriteLine("Light rain expected.");
            }
            else if (rainIndex < 10 && Warning)
            {
                Console.WriteLine("Moderate rain expected.");
            }
            else if (rainIndex > 10 && rainIndex < 30 && Warning)
            {
                Console.WriteLine("Heavy rain expected.");
            }
            else if (rainIndex > 30 && Warning)
            {
                Console.WriteLine("Severe rain expected.");
            }
        }
    }
}