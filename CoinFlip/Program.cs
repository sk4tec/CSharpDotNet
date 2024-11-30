// See https://aka.ms/new-console-template for more information
Console.WriteLine("Coin Flip with 50/50 chance!");

var random = new Random();

for (int i = 0; i < 1000; i++)
{
    var num = random.Next(0, 2); // note that 0 is inclusive and 2 is exclusive so its 0-1
    var result = num == 0 ? 0 : num;
    Console.WriteLine(num == 0 ? "heads" : "tails");
}