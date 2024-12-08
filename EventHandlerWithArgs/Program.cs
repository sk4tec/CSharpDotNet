// See https://aka.ms/new-console-template for more information
Console.WriteLine("Event Handler fun but this time with args.. yay!");

// Usage
var publisher = new Publisher();
var subscriber = new Subscriber();

publisher.LogCreated += subscriber.OnLogCreatedHandler;
publisher.CreateLog();


// Publisher Class
public class Publisher
{
    public event EventHandler<LogArgs>? LogCreated;
    protected virtual void OnLogCreated(string logMessage) // virtual allows derived classes to override the method
    {
        LogCreated?.Invoke(this, new LogArgs(logMessage, DateTime.Now));
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
    public void OnLogCreatedHandler(object? sender, LogArgs logArgs)
    {
        Console.WriteLine($"from object {sender?.ToString()}");
        Console.WriteLine($"Log message {logArgs.LogMessage} received: {logArgs.LogTime}");
    }
}

public class LogArgs: EventArgs
{
    public string LogMessage { get; set; }
    public DateTime LogTime { get; set; } = DateTime.Now;
    public LogArgs(string logMessage, DateTime logtime)
    {
        LogMessage = logMessage;
        LogTime = LogTime;
    }
}