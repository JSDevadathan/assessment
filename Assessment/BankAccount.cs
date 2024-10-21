using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class BankAccount
    {
        private int AccountNumber { get; set; }
        private string AccountHolderName { get; set; }
        private double Balance { get; set; }

        public BankAccount(int accountNumber, string accountHolderName, double initialBalance = 0)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }


        public void deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Balance += amount;
            Console.WriteLine($"New balance: {Balance:C}");

        }

        public void withdrawal(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            Balance -= amount;
            Console.WriteLine($"New balance: {Balance:C}");

        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("AccountHolderName: " + AccountHolderName);
            Console.WriteLine("Balance: " + Balance);
        }


    }
}
