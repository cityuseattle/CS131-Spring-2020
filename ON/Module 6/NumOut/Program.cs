using System;
using System.Globalization;

namespace NumOut
{
    class Program
    {
        static void Main()
        {
            double value = 987654.321;
            //display with 2 decimal points
            Console.WriteLine(value.ToString("0.##"));
            //display as integer
            Console.WriteLine(value.ToString("0"));
            //display as currency
            Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));
        }
        
    }
}
