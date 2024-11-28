using System;
class Program
{
    static void Main(string[] args)
    {
        var kph = ConvertToKph(100m);
        Console.WriteLine(kph);
    }

    static decimal ConvertToKph(decimal mph)
    {
        return mph * 1.6093m;
    }
}