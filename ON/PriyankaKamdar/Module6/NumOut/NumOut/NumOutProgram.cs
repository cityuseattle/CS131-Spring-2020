using System;

namespace NumOut
{
    class NumOutProgram
    {
        static void Main(string[] args)
        {
            double value = 987654.321d;
            Console.WriteLine(value.ToString(".00"));     // will give the output with 2 decimal point
            Console.WriteLine(value.ToString("0"));      // will give the output as an Integer
            Console.WriteLine(value.ToString("C"));     // will give the output as a currency value
        }
    }
}
