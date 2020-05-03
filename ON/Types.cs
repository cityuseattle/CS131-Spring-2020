using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int Distance = 77;// Gave integer the value of 77
            float Length = 22.25f;// Gave float the value of 22.25
            string Overall = "Value 100";// Gave string the value of 'Value 100

            int FloatToInt = (int)Length;// Casted the float value to integer

            Console.WriteLine(FloatToInt);
            Console.WriteLine(Distance);
            Console.WriteLine(Overall);
            Console.WriteLine(Length);

            Console.WriteLine("When you cast a double to an integer everything to the right of the decimal disappears and the big decimal now turns into a regular number");

        }
    }   
}