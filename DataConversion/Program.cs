// See https://aka.ms/new-console-template for more information
Console.WriteLine("Data Conversion fun!");

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}"); // Decimal: 1.23456789
Console.WriteLine($"Float  : {myFloat}");   // Float  : 1.2345679

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum); // 12

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value3 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value3);