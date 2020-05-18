using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Net;
using System.Security.Cryptography;

namespace MailString
{
    class MailStringProgram
    {
        public static string GenerateEmail(string firstName,string lastName)
        {
            string id = "@abc.com";
            string firstCharacters = firstName.Substring(0, 1);
            string lastCharacters = lastName.Substring(0, 3);
            string emailAddress = firstCharacters + lastCharacters + id;
            return emailAddress;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateEmail("priyanka","kamdar"));   //Calling GenerateEmail method and displaying result
            Console.WriteLine(GenerateEmail("vivek", "kamdar"));     //Calling GenerateEmail method and displaying result
            Console.WriteLine(GenerateEmail("darshan", "botadra"));   //Calling GenerateEmail method and displaying result
        }

    }
}
