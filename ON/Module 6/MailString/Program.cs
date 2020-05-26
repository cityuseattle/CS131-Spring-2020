using System;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks.Dataflow;

namespace MailString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type your first name please: ");
            string firstName;
            firstName = Console.ReadLine();

            Console.WriteLine("Type your last name please:");
            string lastName;
            lastName = Console.ReadLine();

            string name = $"Your new email is: {firstName[0]}{lastName}@abc.com";
            Console.WriteLine(name);
            

        

       
        }
    }
}
