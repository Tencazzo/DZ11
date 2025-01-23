using DZ11.ClassesforBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ11.ClassesClassesforBank
{
    public class AccountAdministration
    {
        private Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>();

        public string CreateAccount(string holderName)
        {
            var account = new BankAccount(holderName);
            accounts[account.AccountNumber] = account;
            return account.AccountNumber;
        }

        public void CloseAccount(string accountNumber)
        {
            accounts.Remove(accountNumber);
        }

        public BankAccount GetAccount(string accountNumber)
        {
            accounts.TryGetValue(accountNumber, out var account);
            return account;
        }
    }
}
