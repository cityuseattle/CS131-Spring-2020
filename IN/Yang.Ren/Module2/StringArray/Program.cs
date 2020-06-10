using System;

namespace StringArray
{
    class Program
    {
        static void Main()
        {
            const int NUM_CITY = 4;
            const int Seattle = 0; const int Loa = 1; const int NY = 2; const int WashingtonDC = 3;

            string[] name = new string[NUM_CITY];
            name[Seattle] = "Seattle";
            name[Loa] = "Loa";
            name[NY] = "NY";
            name[WashingtonDC] = "WashingtonDC";


            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name[2]);
            Console.WriteLine(name[3]);
        }
    }
}
