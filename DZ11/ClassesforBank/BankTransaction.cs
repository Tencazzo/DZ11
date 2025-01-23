using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ11.ClassesforBank
{
    public class BankTransaction
    {
        public DateTime Date { get;private set; }
        public decimal Amount { get;private set; }

        public BankTransaction(decimal amount)
        {
            Amount = amount;
            Date = DateTime.Now;
        }
    }
}
