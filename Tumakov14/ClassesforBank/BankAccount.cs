#define DEBUG_ACCOUNT
using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace Tumakov14.ClassesforBank
{
    public class BankAccount
    {
        private static List<string> existingNumbers = new List<string>();
        private decimal balance;

        public string AccountNumber { get; }
        public string HolderName { get; }

        public BankAccount(string holderName)
        {
            HolderName = holderName;
            AccountNumber = GenerateUniqueNumber();
        }

        private string GenerateUniqueNumber()
        {
            Random random = new Random();
            string newNumber;
            do
            {
                newNumber = random.Next(1, 100000).ToString();
            } while (existingNumbers.Contains(newNumber));
            existingNumbers.Add(newNumber);
            return newNumber;
        }

        public void Deposit(decimal amount) => balance += amount;

        public void Withdraw(decimal amount)
        {
            if (amount <= balance) balance -= amount;
        }

        public void Transfer(BankAccount targetAccount, decimal amount)
        {
            if (amount <= balance)
            {
                Withdraw(amount);
                targetAccount.Deposit(amount);
            }
        }

        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"Номер счёта: {AccountNumber}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Имя держателя: {HolderName}");
        }
    }
}
