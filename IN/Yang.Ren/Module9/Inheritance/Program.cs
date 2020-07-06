using Inheritance;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        public static void Main()
        {
            const decimal OPENNING_BALANCE = 55m;
            const decimal MONTHLY_INTEREST = 0.0033m;


            JointSavings jointSavings = new JointSavings("George", "Jane",OPENNING_BALANCE);
            jointSavings.AddMonthlyInterest(MONTHLY_INTEREST);
            jointSavings.ShowBalance();
        }
    }

    class Account
    {
        protected decimal BankBalance { set; get; }

        protected Account()
        {
            Console.WriteLine();
            Console.WriteLine("Inside the Account constructor.");
        }
        public void ShowBalance()
        {
            Console.WriteLine("The balance is " + BankBalance.ToString("C"));
        }
    }

    class Savings : Account
    {
        public Savings(decimal balance)
        {
            Console.WriteLine("Inside the Savings constructor.");
            BankBalance = balance;
        }
        public void AddMonthlyInterest(decimal interest)
        {
            BankBalance *= (1.0m + interest);

        }
    }
    class Checking : Account
    {
        public Checking(decimal balance)
        {
            Console.WriteLine("Inside the Checking constructor.");
            BankBalance = balance;
        }
        public void DeductServiceCharge()
        {
            const decimal CHECKING_FEE = 1.50m;
            BankBalance -= CHECKING_FEE;
        }
    }

    class JointSavings : Savings
    {
        public JointSavings(string A, string B,decimal balance) : base(balance)
        {
            string firstNameA = A;
            string firstNameB = B;
            BankBalance = balance;
            Console.WriteLine("Inside the default JointSavings constructor.");
            Console.WriteLine("The account owner are: " + firstNameA + " and " + firstNameB);
        }

        private string firstNameA;
        private string firstNameB;
    }
}