// See https://aka.ms/new-console-template for more information
Console.WriteLine("Scope Challenge!");

// Original code - tidy this up. Optimize your code for readability. Depending on the amount of whitespace
// that you include and some other factors, you should have around 17 lines of code.
// The output should be:
// Set contains 42
// Total: 108
/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
       bool found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}
*/

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");