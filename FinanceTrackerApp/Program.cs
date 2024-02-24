using System.Text.Json;

namespace financeTracker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            
            // Provide a console-based UI that allows users to interact with the finance tracker. 
            // Users can add new transactions, view transaction history, and see financial summaries based on 
            // categories or overall.
            
            Transaction transaction = new Transaction(Guid.NewGuid(), DateTime.Now, "pizza", 100, "Restaurants");

            WriteTransactionDetails(transaction);
        }

        static void WriteTransactionDetails(Transaction transaction)
        {
            Console.WriteLine($"ID: {transaction.Id}");
            Console.WriteLine($"Date: {transaction.Date}");
            Console.WriteLine($"Description: {transaction.Description}");
            Console.WriteLine($"Amount: {transaction.Amount}");
            Console.WriteLine($"Category: {transaction.Category}");
        }
    }
}