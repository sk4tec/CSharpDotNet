// See https://aka.ms/new-console-template for more information
Console.WriteLine("Event Handler fun... yay!");

// Usage
var publisher = new Publisher();
var subscriber = new Subscriber();

publisher.LogCreated += subscriber.OnLogCreatedHandler;
publisher.CreateLog();


// Publisher Class
public class Publisher
{
    public event EventHandler<String>? LogCreated;
    protected virtual void OnLogCreated(string logMessage) // virtual allows derived classes to override the method
    {
        LogCreated?.Invoke(this, logMessage);
    }

    public void CreateLog()
    {
        // Simulate log creation
        Console.WriteLine("Log created.");
        OnLogCreated("Some log message");
    }
}

// Subscriber Class
public class Subscriber
{
    public void OnLogCreatedHandler(object? sender, string logMessage)
    {
        Console.WriteLine($"from object {sender?.ToString()}");
        Console.WriteLine($"Log message received: {logMessage}");
    }
}
