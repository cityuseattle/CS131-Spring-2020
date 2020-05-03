using System;

namespace Scopes
{
    class Program

    {
        public static string Str2;
        static void ReturnString(string Strl)
        {
            Str2 = "Programming in C#";

            Console.Write(Strl);
        }
                        
        static void Main(string[] args)
        {
            ReturnString("CS131 ");
            Console.WriteLine(Str2);

        }
    }
}
