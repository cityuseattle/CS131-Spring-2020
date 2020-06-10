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


            Savings savings = new Savings(OPENNING_BALANCE);
            savings.AddMonthlyInterest(MONTHLY_INTEREST);
            savings.ShowBalance();

            Checking checking = new Checking(OPENNING_BALANCE);
            checking.DeductServiceCharge();
            checking.ShowBalance();


            JointSavings jointSavings = new JointSavings("Test1", "Test2", OPENNING_BALANCE);
          
            jointSavings.AddMonthlyInterest(MONTHLY_INTEREST);
            jointSavings.ShowBalance();

            Console.ReadLine();
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
    class Savings :Account 
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
class Checking :Account
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

class JointSavings :Savings
{
        public JointSavings(decimal balance，"Test1", "Test2", OPENNING_BALANCE )
        {
             firstNameA = "Groge";
             firstNameB = "Jane";
            Console.WriteLine("Inside the default Savings constructor.");
            BankBalance = balance;
        }
        public void AddMonthlyInterest(decimal interest)
        {
            BankBalance *= (1.0m + interest);
        }

}