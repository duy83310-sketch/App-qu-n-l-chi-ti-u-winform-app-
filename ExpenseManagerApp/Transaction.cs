using System;

namespace ExpenseManagerApp
{
    /// <summary>
    /// Data model class representing an Income or Expense transaction.
    /// </summary>
    public class Transaction
    {
        public int TransactionID { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int CategoryID { get; set; }
        public int PaymentMethodID { get; set; }
        public string Notes { get; set; }
        public string UserName { get; set; }

        public Transaction() { }
    }
}
