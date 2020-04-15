using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           //These are the set variables
           int Age = 25;
           bool isFemale = false;
           double MyFloat = 10.1;


           //Reads the 
           Console.Write("What is your name?");
           string Name = Console.ReadLine(); //reads the Users prompt
           Console.WriteLine("Hello "+ Name);

           //continues the program
           Console.WriteLine("You are " + Age);
           Console.WriteLine(isFemale);
           Console.WriteLine(MyFloat);
        }
    }
}