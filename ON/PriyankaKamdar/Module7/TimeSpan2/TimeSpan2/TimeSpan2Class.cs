using System;

namespace TimeSpan2
{
    class TimeSpan2Class
    {
        static void compareTimeSpan(TimeSpan programmingTime, TimeSpan testingTime)
        {
            if(programmingTime.CompareTo(testingTime) > 0) //When programming Time span is greater than testingTime.
            {
                Console.WriteLine("Programming time in week is more than testing time.");
            }
            else if (programmingTime.CompareTo(testingTime) == 0) //When programming and testing time are equal.
            {
                Console.WriteLine("Programming and testing time in week is equal.");
            } 
            else //When testing time more than programming time.
            {
                Console.WriteLine("Testing time in week is more than programming time.");
            }
        }
        static void Main(string[] args)
        {
            TimeSpan weeklyProgrammingTime = new TimeSpan(30, 20, 00); //create TimeSpan for development time.
            TimeSpan weeklyTestingTime = new TimeSpan(10, 40, 00); //create TimeSpan for testing time.
            TimeSpan totalDevelopmentTime = weeklyProgrammingTime.Add(weeklyTestingTime); //Add programming and testing time.
            Console.WriteLine("Total Development in hours: " + totalDevelopmentTime.TotalHours.ToString("N2")); //Total development time in hours.
            compareTimeSpan(weeklyProgrammingTime, weeklyTestingTime); //call compareTimeSpan.
        }
    }
}
