using System;

namespace MailString
{
    class Program
    {
        static void Main(string[] args)
        {
                string go = "";
            do
            {
                Console.Write("Enter your first name; ");
                string first = Console.ReadLine();
                Console.Write("Enter your last name; ");
                string last = Console.ReadLine();

                string email = first.Substring(0, 1) + last.Substring(0, 5) + "@abc.com";

                Console.WriteLine("Your new email is {0}", email);
                Console.WriteLine("Press any key to create another email address, or ‘q' to quir");
                go = Console.ReadLine();
            } while (go != "q");

            Console.ReadKey();
        }
    }
}
