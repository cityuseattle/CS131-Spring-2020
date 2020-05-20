using System;
using System.Runtime.CompilerServices;

namespace Yi_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            //introduce variables to describe birthday
            const int MTH = 4;
            const int DY = 29;
            const int YR = 1994;
            const int HR = 8;
            const int MIN = 31;
            const int SEC = 42;
            
            //establish Date time to display my birthday
            DateTime BDay = new DateTime(YR, MTH, DY, HR, MIN, SEC);
            ShowBirthday(BDay);
        }
        
        //Method that displays Birthday
        public static void ShowBirthday(DateTime DT)
        {
            Console.WriteLine("David's Birth Information: ");
            Console.WriteLine($"Year: {DT.Year}\nMonth: {DT.Month}\nDay: {DT.Day}\n" +
                              $"Hour: {DT.Hour}\nMinutes: {DT.Minute}\nSeconds: {DT.Second}");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }
    }
}