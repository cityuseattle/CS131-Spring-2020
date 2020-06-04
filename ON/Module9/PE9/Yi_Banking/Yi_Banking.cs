using System;

namespace Yi_Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal OPENING_BALANCE = 55m;
            const decimal MONTHLY_INTEREST = 0.0033m;
            
            //Savings object is instantiated
            Savings savings = new Savings(OPENING_BALANCE);
            savings.AddMonthlyInterest(MONTHLY_INTEREST);
            savings.ShowBalance();

            //Checking object is instantiated
            Checking checkings = new Checking(OPENING_BALANCE);
            checkings.DeductServiceCharge();
            checkings.ShowBalance();
    
            //JointSavings object is instantiated
            JointSavings jtsavings = new JointSavings("David", "Adrianna", OPENING_BALANCE);
            jtsavings.AddMonthlyInterest(MONTHLY_INTEREST);
            jtsavings.ShowBalance();
            Console.ReadLine();
            
        }
    }

    class Account
    {
        //protected variables to ensure proper usage across classes.
        protected decimal BankBalance { set; get; }
        protected string FirstNameA { set; get; }
        protected string FirstNameB { set; get; }

        protected Account()
        {
            Console.WriteLine();
            Console.WriteLine("Inside the Account constructor.");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"The balance is: {BankBalance.ToString("C")}");
        }
    }

    //Creates the Savings child class
    class Savings : Account
    {
        public Savings(decimal balance)
        {
            Console.WriteLine("==> Savings Constructor.");
            BankBalance = balance;
        }
        

        public void AddMonthlyInterest(decimal interest)
        {
            BankBalance *= (1.0m + interest);
        }
    }
    
    //Creates the JointSavings class which inherits data from Savings
    class JointSavings : Savings
    {
        public JointSavings(string firstnameA, string firstnameB, decimal balance) : base(balance)
        {
            Console.WriteLine("====> Joint Savings Constructor");
            BankBalance = balance;
            FirstNameA = firstnameA;
            FirstNameB = firstnameB;
            Console.WriteLine($"The account holders are: {firstnameA} and {firstnameB}");
        }
    }

    //Creates the child class Checking
    class Checking : Account
    {
        public Checking(decimal balance)
        {
            Console.WriteLine("==> Checking constructor.");
            BankBalance = balance;
        }
        public void DeductServiceCharge()
        {
            const decimal CHECKING_FEE = 1.50m;
            BankBalance -= CHECKING_FEE;
        }
    }
}