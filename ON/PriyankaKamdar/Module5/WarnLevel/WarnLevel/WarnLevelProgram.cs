using System;
using System.Security.Cryptography;

namespace WarnLevel
{
    class WarnLevelProgram
    {    //Define constant to show risk levels.
        const int LOW_RISK =1, MEDIUM_RISK = 2 , HIGH_RISK = 3;
        //Method to display risk level.
        public static void RiskLevel(int risk)
        {
            if (risk == LOW_RISK)
            {
                Console.WriteLine("Risk: " + LOW_RISK + "- Risk level is low");
            }
            else if (risk == MEDIUM_RISK)
            {
                Console.WriteLine("Risk: " + MEDIUM_RISK + "- Risk level is Medium.");
            }
            else if (risk == HIGH_RISK)
            {
                Console.WriteLine("Risk: " + HIGH_RISK + "- Risk level is High.");
            }
            else
            {
                Console.WriteLine("Risk: " + risk + "- There is no Risk.");
            }
        }
            static void Main(string[] args)
            {
                RiskLevel(1);       //call RiskLevel method.
                RiskLevel(2);      //call RiskLevel method.
                RiskLevel(3);     //call RiskLevel method.
                RiskLevel(0);    //call RiskLevel method.
                Console.ReadLine(); 
            }
        
    }
}
