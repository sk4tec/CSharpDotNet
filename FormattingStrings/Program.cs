// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, 2025! Lets do some string formatting!");

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);