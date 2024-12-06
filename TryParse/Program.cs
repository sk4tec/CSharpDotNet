// See https://aka.ms/new-console-template for more information
Console.WriteLine("Try Parse fun!");

//string value = "102";
string value = "bad";
int result = 0;

if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");