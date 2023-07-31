using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBankingingApp
{
    public class BankAccount
    {
        private List<Transaction> AllListedTransaction = new List<Transaction>();

        private static int BankAccountNumber = 1234567890;
        public string Number { get; set; }
        public string Owner { get; set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (Transaction t in AllListedTransaction)
                {
                    balance = balance + t.Amount;
                }
                return balance;
            }
        }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name.ToString().ToUpper();
            MakeDeposite(initialBalance, DateTime.Now, "initiacial balance");
            this.Number = BankAccountNumber.ToString();
            BankAccountNumber++;
        }

        public void MakeDeposite(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            var deposit = new Transaction(amount, date, note);
            AllListedTransaction.Add(deposit);
        }

        public void MakeWithdral(decimal amount, DateTime date, string note, string owner)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            AllListedTransaction.Add(withdrawal);
        }
    }
}