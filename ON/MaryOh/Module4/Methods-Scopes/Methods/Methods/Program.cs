using System;

namespace Methods
{
    class Program
    {
        // this is a method called "PrintSomething"
        // its function is to print a line of string "Hello World!"
        public static void PrintSomething() {
            Console.WriteLine("Hello World!");
        }

        // this is a method called "Main"
        // this method is called when the program is ran
        static void Main(string[] args)
        {
            PrintSomething(); // mmethod "PrintSomething" is called
        }
    }
}
