// See https://aka.ms/new-console-template for more information

/* Counter numbers from 1 - 100. When the number is a mutliple of 3 print "Fizz". 
 * When the m the number is a mutliple 5 print "Buzz". When the number is a mutliple of 3 and 5 print "FizzBuzz".
 * Otherwise print the number
 */

Console.WriteLine("Fizz buzz!");

for (int i = 1; i < 100; i++) 
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0) 
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0) 
    {
        Console.WriteLine("Buzz");
    } 
    else
    {
        Console.WriteLine($"{i}");
    }
}