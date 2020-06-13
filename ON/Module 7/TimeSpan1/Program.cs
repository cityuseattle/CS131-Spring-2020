using System;

namespace TimeSpan2

{
    class Program
    {
        public static void Main()
        {
           int DAY = 0, HRSA = 10, HRSB= 5, SEC = 0;

            TimeSpan tsA = new TimeSpan(DAY, HRSA, SEC);  //10 hours
            TimeSpan tsB = new TimeSpan(DAY, HRSB, SEC);  //5 hours
            TimeSpan tsC = tsA + tsB;            // returns 15 hours


            Console.WriteLine(tsC);
           
          




        }
    }
}
