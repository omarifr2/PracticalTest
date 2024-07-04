public class Database
{
    public void SaveData(string data)
    {
        Console.WriteLine("Data saved to database.");
    }
}

public class BusinessLogic
{
    private Database _database = new Database();

    public void ProcessData(string data)
    {
        // Process data
        Console.WriteLine("Processing data.");

        // Save data to database
        _database.SaveData(data);
    }
}