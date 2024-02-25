using System.Text.Json;

namespace financeTracker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            DisplayUI();
            
            // Provide a console-based UI that allows users to interact with the finance tracker. 
            // Users can add new transactions, view transaction history, and see financial summaries based on 
            // categories or overall.
            
            // Transaction transaction = new Transaction(Guid.NewGuid(), DateTime.Now, "pizza", 100, "Restaurants");

            // WriteTransactionDetails(transaction);
        }

        static void WriteTransactionDetails(Transaction transaction)
        {
            Console.WriteLine($"ID: {transaction.Id}");
            Console.WriteLine($"Date: {transaction.Date}");
            Console.WriteLine($"Description: {transaction.Description}");
            Console.WriteLine($"Amount: {transaction.Amount}");
            Console.WriteLine($"Category: {transaction.Category}");
        }

        static void DisplayUI(){
            do{
                Console.Clear();
                Console.WriteLine("Welcome in Finance tracer app!");
                Console.WriteLine("1. New transaction.");
                Console.WriteLine("2. History");
                Console.WriteLine("3. Summary");
                Console.WriteLine("4. Quit");
                
                string? userInput = "";
                Console.Write(">");
                userInput = Console.ReadLine();

                switch(userInput){
                    case "1":
                        //New transaction
                        break;
                    case "2":
                        //History
                        break;
                    case "3":
                        //Summary
                        break;
                    case "4":
                        Console.WriteLine("Closing the app...");
                        return;
                    default:
                        Console.WriteLine("Wrong input. Please try agian!");
                    break;
                }
            }while(true);
        }
    }
}