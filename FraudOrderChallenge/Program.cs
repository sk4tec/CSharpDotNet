// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fraud Order Challenge!");

string[] orders = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string order in orders) 
{
    if (order.StartsWith('B'))
    {
        Console.WriteLine($"Reporting order as it starts with B {order}");
    }
}
