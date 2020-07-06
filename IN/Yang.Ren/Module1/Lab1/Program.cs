using System;
// using static System;Conmsole;  this line is not necessary


namespace HelloWorldProgram
{
    class Helloworld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReadKey();
        }

        private static void ReadKey()
        {
            throw new NotImplementedException(); // through I thought it was nor true but still a solution
        }
    }
}
