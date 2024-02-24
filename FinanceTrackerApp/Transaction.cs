using System;

public class Transaction
{
    public Guid ID { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }

    // Constructor
    public Transaction(DateTime date, string description, decimal amount, string category)
    {
        ID = Guid.NewGuid();
        Date = date;
        Description = description;
        Amount = amount;
        Category = category;
    }

    // Method to convert object to JSON
    /*public string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }*/

    // Method to deserialize JSON into object
    /*public static Transaction FromJson(string json)
    {
        return JsonSerializer.Deserialize<Transaction>(json);
    }*/
}
