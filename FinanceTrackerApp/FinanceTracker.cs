namespace financeTracker
{
    interface IFinance
    {
        //Specifies methods for adding, viewing, and categorizing transactions.
    }

    interface IFinanceStorage
    {
        //Specifies methods for loading and saving transaction data.
    }

    class Transaction
    {
        // ID should use the type Guid (i.e., public Guid ID {get; set; } = Guid.NewGuid();
        // Constructor initializes a transaction with the provided details.
        
        public Transaction(Guid transactionId, DateTime date, string description, decimal amount, string category)
        {
            
        }
    }

    class FinanceTracker : IFinance
    {
        // Implements the IFinance interface, managing a list of Transaction objects. 
        // It includes functionality to add transactions, categorize them, 
        // and provide summaries (e.g., total income, total expenses, balance).
    }
}