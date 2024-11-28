class Program
{
    static void Main(string[] args)
    {
        string name = RemoveLastCharacter("SunjBob1");
        Console.WriteLine(name);
    }

    static string RemoveLastCharacter(string value)
    {
        return value.Remove(value.Length - 1);
    }
}