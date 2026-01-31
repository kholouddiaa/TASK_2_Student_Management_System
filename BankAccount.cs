using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2___Student_Management_System
{
    internal class BankAccount
    {

        public string AccountNumber;
        public string OwnerName;
        public double Balance;


        public BankAccount(string accountNumber, string ownerName, double initialBalance)
        { 
            if (!accountNumber.All(char.IsDigit) ||accountNumber.Length != 14)
            {
                throw new ArgumentException("Account number must be exactly 14digits.");
            } 
            if (initialBalance<1000)   
            {
                throw new ArgumentException("Initial balance must be at least 1000.");
            }   
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = initialBalance;

        }
        public void Deposit( double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount >=Balance)
            {
                throw new InvalidOperationException("Insufficient funds for this withdrawal.");
            }
            Balance -= amount;
        }

        public string GetOwnerName( double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            return OwnerName;
        } 
        public double GetBalance()
        {
            return Balance;
        }

       
      
        public void DisplayInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Owner Name: {OwnerName}");
            Console.WriteLine($"Balance: {Balance}");
        }


    }
}
