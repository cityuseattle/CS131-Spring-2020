using System;

namespace Yi_TimeSpan2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables for Weekly Programming Hours
            int WkProgDay = 4;
            int WkProgHour = 2;
            int WkProgMin = 32;
            int WkProgSec = 45;
            
            //Variables for Weekly Testing Hours
            int WkTestDay = 2;
            int WkTestHour = 13;
            int WkTestMin = 45;
            int WkTestSec = 23;
            
            //Writes out time span for both the weekly programming and testing hours
            TimeSpan WkProg = new TimeSpan(WkProgDay, WkProgHour, WkProgMin, WkProgSec);
            TimeSpan WkTest = new TimeSpan(WkTestDay, WkTestHour,WkTestMin,WkTestSec);
            
            //Adds the two time spans together to get total work time
            TimeSpan TtlDevTime = (WkProg + WkTest);
            
            //Writes the data.
            Console.WriteLine($"The total development time for this project was: {TtlDevTime.Days} days, " +
                              $"{TtlDevTime.Hours} hours, {TtlDevTime.Minutes} minutes, and {TtlDevTime.Seconds} seconds.");

        }
    }
}