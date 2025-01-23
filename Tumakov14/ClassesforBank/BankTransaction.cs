using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov14.ClassesforBank
{
    public class BankTransaction
    {
        public DateTime Date { get;set; }
        public decimal Amount { get;set; }

        public BankTransaction(decimal amount)
        {
            Amount = amount;
            Date = DateTime.Now;
        }
    }
}
