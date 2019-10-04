using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q3
{
    class BankAccount
    {
        private int _accountNumber;
        private decimal _balance;
        private string _accountHolder;

        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount()
        { 
        }

        public BankAccount(int num,string name,decimal bal)
        {
            AccountNumber = num;
            AccountHolder = name;
            Balance = bal;
        }

        public override string ToString()
        {
            return $"Account Number {AccountNumber} in the name of {AccountHolder} has a balance of {Balance}\n";
        }

        public void Deposit (decimal deposit)
        {
            Balance = Balance + deposit;
        }

        public void Withdraw (decimal takeout)
        {
            Balance = Balance - takeout;
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account number = {AccountNumber}");
            Console.WriteLine($"Account name = {AccountHolder}");
            Console.WriteLine($"Account balance = {Balance}\n");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount numerouno = new BankAccount(0897654, "Johnny Poorboy", 3.50M);
            BankAccount numeroduo = new BankAccount(0567889, "Victor Creosote", 199999.99M);

            Console.WriteLine(numerouno + "\n");
            Console.WriteLine(numeroduo + "\n");



            Console.Write("Please choose an amount to deposit in 1st account:  ");
            numerouno.Deposit(decimal.Parse(Console.ReadLine()));

            Console.WriteLine(numerouno +"\n");
            
            Console.Write("Please choose an amount to withdraw from the second account:  ");
            numeroduo.Withdraw(decimal.Parse(Console.ReadLine()));
            
            Console.WriteLine(numeroduo + "\n");

            numerouno.DisplayAccountInfo();

            numeroduo.DisplayAccountInfo();
        }
    }
}
