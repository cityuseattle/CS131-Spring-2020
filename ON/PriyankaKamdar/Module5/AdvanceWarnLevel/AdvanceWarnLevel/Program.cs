using System;

namespace AdvanceWarnLevel
{
    class Program
    {
        //Define constant to show risk levels.
        
        //Method to display risk level.
        public static void RiskLevel(int risk, bool displayWarning)
        {

            if ((risk >= 1 && risk <= 5) && displayWarning) {              //Low level risk range is 1 to 5. 
            
                Console.WriteLine("Risk: " + risk + "- Risk level is low");
            } 
            else if ((risk >= 6 && risk <= 10) && displayWarning)         //Medium level risk range is 6 to 10.
            {
                Console.WriteLine("Risk: " + risk + "- Risk level is Medium.");
            }
            else if ((risk >= 11 && risk <= 15) && displayWarning)         //High level risk range is 11 to 15.
            {
                Console.WriteLine("Risk: " + risk + "- Risk level is High.");
            }
            else if ((risk < 0 || risk > 15) && displayWarning)           // If risk level is more than 15 or less than 0.
            {
                Console.WriteLine("Risk: " + risk + "- Not a valid risk");
            }
            else if(displayWarning == true)
            {
                Console.WriteLine("Risk: " + risk + "- No risk.");
            }
            else
            {
                Console.WriteLine("Risk: " + risk + "-Risk level wont be displayed.");
            }
        }
        static void Main(string[] args)
        {
            RiskLevel(2, true);     
            RiskLevel(3, false);     
            RiskLevel(10, true);     
            RiskLevel(8, false);
            RiskLevel(11, true);
            RiskLevel(15, false);
            RiskLevel(0, true);
            RiskLevel(-1, true);
            RiskLevel(17, true);
            Console.ReadLine();
        }
    }
}
