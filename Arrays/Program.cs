// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arrays Fun... yay!");

string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets); //note that we call a static method on the Array class

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");

Array.Reverse(pallets);

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
