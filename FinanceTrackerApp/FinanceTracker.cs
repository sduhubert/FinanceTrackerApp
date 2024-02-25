using System.Data.Common;
using System.Text.Json;

namespace financeTracker
{
    interface IFinance
    {
        //Specifies methods for adding, viewing, and categorizing transactions.
        public void AddTransaction();
        // public void History();
        public void DisplayTransaction();
    }

    interface IFinanceStorage
    {
        static abstract void Save(Transaction transaction, string fileName);
        abstract static List<Transaction> Load(string fileName);
    }

    public class Transaction
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }

        // Constructor initializes a transaction with the provided details.
        public Transaction(Guid id, DateTime date, string description, decimal amount, string category)
        {
            Id = id;
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

        private List<Transaction> transactions = new List<Transaction>();


         public void AddTransaction()
        {
            Console.WriteLine("Enter transaction details:");
            Console.Write("Description: ");
            string description = Console.ReadLine();
            decimal amount;
            do
            {
                Console.Write("Amount: ");
            } while (!decimal.TryParse(Console.ReadLine(), out amount));

            Console.Write("Category: ");
            string category = Console.ReadLine();

            Transaction transaction = new Transaction(Guid.NewGuid(), DateTime.Now, description, amount, category);
            transactions.Add(transaction);
            Console.WriteLine("Transaction added successfully.");
        }
        public void DisplayTransaction()
        {
            if (transactions.Count == 0)
            {
                Console.WriteLine("No transactions to display.");
                return;
            }

            Console.WriteLine("Transaction History:");
            foreach (var transaction in transactions)
            {
                Console.WriteLine("======================================");
                Console.WriteLine($"Date: {transaction.Date}, Description: {transaction.Description}, Amount: {transaction.Amount}, Category: {transaction.Category}");
            }
        }


        public void Summary()
        {
            decimal totalIncome = 0;
            decimal totalExpenses = 0;

            foreach (var transaction in transactions)
            {
                if (transaction.Amount >= 0)
                    totalIncome += transaction.Amount;
                else
                    totalExpenses += transaction.Amount;
            }

            decimal balance = totalIncome + totalExpenses;

            Console.WriteLine($"Total Income: {totalIncome}");
            Console.WriteLine($"Total Expenses: {totalExpenses}");
            Console.WriteLine($"Balance: {balance}");
        }
    }

    public class JsonFinanceStorage : IFinanceStorage
    {
        // Implementes the IFinanceStorage interface, 
        // focusing on handling persistence 
        // by reading from and writing to a transactions.json JSON file, 
        // managing serialization and deserialization of Transaction objects.

        public static void Save(Transaction transaction, string fileName)
        {
            string json = JsonSerializer.Serialize(transaction);
            File.WriteAllText(fileName, json);
        }

        public static List<Transaction> Load(string fileName)
        {
            List<Transaction> newTransactions = new List<Transaction>
            {
                JsonSerializer.Deserialize<Transaction>(File.ReadAllText(fileName))
            };

            foreach (Transaction temp in newTransactions)
            {
                Console.WriteLine($"Id: {temp.Id}, Date: {temp.Date}, Description: {temp.Description}, Amount: {temp.Amount}, Category: {temp.Category}");
            }

            return newTransactions;
        }
    }
}