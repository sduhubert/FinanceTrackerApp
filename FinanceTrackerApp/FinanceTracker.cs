using System.Text.Json;

namespace financeTracker
{
    interface IFinance
    {
        //Specifies methods for adding, viewing, and categorizing transactions.
    }

    interface IFinanceStorage
    {
        void SaveToJson(Transaction transaction, string fileName);
        public List<Transaction> LoadFromJson(string fileName);
    }

    public class Transaction
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }

        // Constructor initializes a transaction with the provided details.
        public Transaction(Guid transactionId, DateTime date, string description, decimal amount, string category)
        {
            Id = transactionId;
            Date = date;
            Description = description;
            Amount = amount;
            Category = category;
        }
    }

    class FinanceTracker : IFinance
    {
        // Implements the IFinance interface, managing a list of Transaction objects. 
        // It includes functionality to add transactions, categorize them, 
        // and provide summaries (e.g., total income, total expenses, balance).
    }

    public class JsonFinanceStorage : IFinanceStorage
    {
        // Implementes the IFinanceStorage interface, 
        // focusing on handling persistence 
        // by reading from and writing to a transactions.json JSON file, 
        // managing serialization and deserialization of Transaction objects.
    }
}