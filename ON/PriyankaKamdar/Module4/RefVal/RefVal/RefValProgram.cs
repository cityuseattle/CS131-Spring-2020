using System;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Net.NetworkInformation;

namespace RefVal
{
    class RefValProgram
    {
        static void Main ()
        {
            float house01 = 625000.00f;
            float house02 = 650000.00f;

            Console.WriteLine("Current Mortgage amount of houses are:-");
            Console.WriteLine("House01: " + house01);
            Console.WriteLine("House02: " + house02);
            YearlyInterestforHouse ( ref house01, ref house02);
            Console.WriteLine("Yearly Interest for houses are:-");
            Console.WriteLine("House01: " + house01);
            Console.WriteLine("House02: " + house02);
            Console.ReadLine();
        }

        public static void YearlyInterestforHouse(ref float house01, ref float house02)
        {
            const float interestRate = 3.25f;
            house01 *= interestRate/100;
            house02 *= interestRate/100;
        }

    }
}
