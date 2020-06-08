using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Account
{
    class Program
    {
        public static void Main()
        {
            const decimal OPENING_BALANCE = 55m;
            const decimal MONTHLY_INTEREST = 0.0033m;

            Savings savings = new Savings(OPENING_BALANCE);            //Created and used Savings object.
            savings.AddMonthlyInterest(MONTHLY_INTEREST);
            savings.ShowBalance();

            Checking checking = new Checking(OPENING_BALANCE);         //Created and used Checking object.
            checking.DeductServiceCharge();
            checking.ShowBalance();

            JointSavings Jsavings = new JointSavings(OPENING_BALANCE); //Created and used Joint Savings object.
            Jsavings.AddMonthlyInterest(MONTHLY_INTEREST);
            Jsavings.ShowBalance();

            Console.ReadLine();
        }

        class Account                                                 // Base Class - Account.
        {
            protected decimal BankBalance { set; get; }
             protected Account()
            {
                Console.WriteLine();
                Console.WriteLine("Inside the Account constructor. ");
            }

            public void ShowBalance()
            {
                Console.WriteLine("The balance is " + BankBalance.ToString("C"));
            }
        }
       

        class Savings : Account                                       // Derived Class - Savings.
        {
            public Savings (decimal balance)
            {
                Console.WriteLine("Inside the Savings constructor.");
                BankBalance = balance;
            }
            public void AddMonthlyInterest(decimal interest)         // Custom Child method.
            {
                BankBalance *= (1.0m + interest);
            }
        }

        class Checking : Account                                   // Derived Class - Checking.
        {
            public Checking(decimal balance)
            {
                Console.WriteLine(" Inside the checking constructor. ");
                BankBalance = balance;

            }
             public void DeductServiceCharge ()                   // Custom Child method.
            {
                    const decimal CHECKING_FEE = 1.50m;
                    BankBalance -= CHECKING_FEE;
             }
        }

        class JointSavings : Savings                             //Derived Class Joint Savings.
        {
            public JointSavings(decimal balance)
            : base(balance)
            {
                Console.WriteLine("Inside the Joint Savings constructor.");  
            }
        }
    }
}
