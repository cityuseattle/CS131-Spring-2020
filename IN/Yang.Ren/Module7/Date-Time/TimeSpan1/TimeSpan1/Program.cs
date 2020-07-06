using System;

namespace TimeSpan1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentdateTime = DateTime.Now;
            int days = DateTime.Now.Day;
            int Hours = DateTime.Now.Hour;
            int Mintues = DateTime.Now.Minute;
            int seconds = DateTime.Now.Millisecond;
            
                Console.WriteLine(days);
            Console.WriteLine(Hours);
            Console.WriteLine(Mintues);
            Console.WriteLine(seconds);
        }
    }
}
