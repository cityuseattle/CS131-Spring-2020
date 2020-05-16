using System;

namespace Yi_MailString
{
    class Program
    {
        static void Main(string[] args)
        {
            string last = "";
            string emailhandle = "@abc.com"; //creates the email handle
            
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine(); //requests the first name
            string fn = firstname.ToLower(); // Puts name into lower case
            
            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine(); //requests the last name
            string ln = lastname.ToLower(); //Put name into lower case

            //If else statement to ensure that all last names are accounted for
            if (ln.Length < 5)
            {
                last = ln;
            }
            else
            {
                last = ln.Substring(0, 5);
            }
            
            //Create the string concatenation
            string email = string.Concat(fn.Substring(0,1), last, emailhandle);
            Console.WriteLine($"Here is your email: {email}");
        }
    }
}