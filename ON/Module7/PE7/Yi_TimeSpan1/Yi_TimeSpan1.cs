using System;

namespace Yi_TimeSpan1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initiate the parameters for timespan
            const int DAY = 1;
            const int HOUR = 23;
            const int MINUTE = 42;
            const int SECONDS = 35;
            
            //Instantiate the timespan 
            TimeSpan Daytime = new TimeSpan(DAY, HOUR, MINUTE, SECONDS);
            
            //Print out the timespan
            Console.WriteLine(
                $"{Daytime.Days} days, {Daytime.Hours} hours, {Daytime.Minutes} minutes, {Daytime.Seconds} seconds.");
        } 
    }
}