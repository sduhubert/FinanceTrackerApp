using System.IO.Enumeration;
using System.Text.Json;
using System.Transactions;

namespace financeTracker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            DisplayUI();

            /*
            string filePath = "transactions.json";
            Transaction pizza = new Transaction(Guid.NewGuid(), DateTime.Now, "pizza", 100, "food");
            JsonFinanceStorage.Save(pizza, filePath);
            JsonFinanceStorage.Load(filePath);
            
            ## what we have here makes a single transaction possible to be stored and loaded from JSON
            ## whoever has an idea to extend it can try it out :)

            */

        }

        static void DisplayUI()
        {
            FinanceTracker financeTracker = new FinanceTracker();

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Finance Tracker app!");
                Console.WriteLine("1. New transaction.");
                Console.WriteLine("2. History");
                Console.WriteLine("3. Summary");
                Console.WriteLine("4. Quit");

                Console.Write(">");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        financeTracker.AddTransaction();
                        PressAnyKey();
                        break;
                    case "2":
                        financeTracker.DisplayTransaction();
                        PressAnyKey();
                        break;
                    case "3":
                        financeTracker.Summary();
                        PressAnyKey();
                        break;
                    case "4":
                        Console.WriteLine("Closing the app...");
                        PressAnyKey();
                        return;
                    default:
                        Console.WriteLine("Wrong input. Please try again!");
                        PressAnyKey();
                        break;
                }
            } 
            while (true);
        }
        
        static void PressAnyKey()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}