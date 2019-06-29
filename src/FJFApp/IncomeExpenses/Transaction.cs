using System;
using System.Collections.Generic;
using System.Linq;

namespace FJFApp.IncomeExpenses
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public decimal BeginningBalance { get; set; }
        public decimal EndingBalance { get; set; }
        public decimal Profit { get; set; }
        public List<TransactionEntry> Incomes { get; set; }
        public List<TransactionEntry> Expenses { get; set; }
        public string Notes { get; set; }
        public Transaction()
        {
            this.Incomes = new List<TransactionEntry>();
            this.Expenses = new List<TransactionEntry>();
        }

        public decimal GetTotalIncome()
        {
            return this.Incomes.Sum(_ => _.Amount);
        }

        public decimal GetTotalExpense()
        {
            return this.Expenses.Sum(_ => _.Amount);
        }
    }

    public class TransactionEntry
    {
        public int Number { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        public string Type { get; set; }
    }
}
