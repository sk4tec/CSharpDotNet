// See https://aka.ms/new-console-template for more information
Console.WriteLine("Parsing Challenge!");

/*
* Complete the required code, placing it within the array looping structure code block.
* It's necessary to implement the following business rules in your code logic:
*
* Rule 1: If the value is alphabetical, concatenate it to form a message.
*
* Rule 2: If the value is numeric, add it to the total.
*
* Rule 3: The result should match the following output:
* Message: ABCDEF
* Total: 68.3
*/

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string Message = "";
double Total = 0;
double val = 0;

foreach (var value in values)
{
    if (double.TryParse(value, out val)) 
    {
        Total += val;
    }
    else 
    {
        Message += value;
    }
}

Console.WriteLine($"Message: {Message}");
Console.WriteLine($"Total: {Total}");


