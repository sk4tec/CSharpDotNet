class Program
{
    static void Main(string[] args)
    {
        string name = RemoveLastCharacter2("SunjBob1");
        Console.WriteLine(name);
    }

    static string RemoveLastCharacter(string value)
    {
        return value.Remove(value.Length - 1);
    }

    static string RemoveLastCharacter2(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return value;
		}

		return value.Substring(0, value.Length - 1);
	}
}