using System;

namespace Enums
{

    enum Gender { Male, Female, other };
    enum Age { Young, Middle, Old };
    enum Hair { Long, Short, Bald };
    enum Height { Tall, Short };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am a " + Gender.Male);
            Console.WriteLine("My Age is " + Age.Young);
            Console.WriteLine("My Hair is " + Hair.Bald);
            Console.WriteLine("My Height is " + Height.Short);
        }
    }
}
