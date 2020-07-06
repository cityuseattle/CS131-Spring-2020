using Microsoft.VisualBasic;
using System;
using System.Reflection.Metadata;

namespace TimeSpan2
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan weeklyprogramingtime = new TimeSpan(11, 30, 0);
            TimeSpan weeklytestingtime = new TimeSpan(5, 25, 11);

            TimeSpan TotalDevelopmentTime = weeklyprogramingtime.Add(weeklytestingtime);

            Console.WriteLine(TotalDevelopmentTime);

            if (TimeSpan.Compare(weeklytestingtime, weeklyprogramingtime) > 0)
            {
                Console.WriteLine("weeklytestingtime is more!");
            }
            else
            { 
                Console.WriteLine("weeklyprogramingtime is more!");
                }
        }
    }
}
