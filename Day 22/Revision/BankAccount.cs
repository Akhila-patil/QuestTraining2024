using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class BankAccount
    {
        private double Balance;
        public string AccountNumber { get;  private set; }
        public string AccountHolderName { get;  private set; }
        public BankAccount(string accountNumber,string accountHolderName,double intitialBalance)
        {
            Balance = intitialBalance;
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be positive");
                return;
            }
            Balance += amount;
            Console.WriteLine($"{amount} is deposited and your balance is:{Balance}");
        }
        public void Withdraw(double amount)
        {
            if(amount<=0 && amount > Balance)
            {
                Console.WriteLine("Amount must be positive or less than balance to withdraw");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"{amount} is withdrawn and your balance is:{Balance}");
        }
        public void GetBalance()
        {
            Console.WriteLine($"Current balance: { Balance}");
        }
    }
}
