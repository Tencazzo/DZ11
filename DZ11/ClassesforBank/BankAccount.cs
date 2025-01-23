using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ11.ClassesforBank
{
    public class BankAccount
    {
        private static List<string> existingNumbers = new List<string>();
        private List<BankTransaction> transactions = new List<BankTransaction>();
        private decimal balance;

        public string AccountNumber { get; private set; }
        public string HolderName { get; private set; }

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

        public void Deposit(decimal amount)
        {
            balance += amount;
            transactions.Add(new BankTransaction(amount));
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                transactions.Add(new BankTransaction(-amount));
            }
        }

        public void Transfer(BankAccount targetAccount, decimal amount)
        {
            if (amount <= balance)
            {
                Withdraw(amount);
                targetAccount.Deposit(amount);
            }
        }
        public BankTransaction this[int index]
        {
            get { return transactions[index]; }
        }
    }
}
