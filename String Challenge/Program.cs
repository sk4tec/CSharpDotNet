// See https://aka.ms/new-console-template for more information
Console.WriteLine("String challenge!");

string pangram = "The quick brown fox jumps over the lazy dog";

var words = pangram.Split(" ");
string[] output = new string[words.Length];

// Use a for loop to keep track of the index
for (int i = 0; i < words.Length; i++)
{
    var wordArray = words[i].ToCharArray();
    Array.Reverse(wordArray);
    output[i] = new string(wordArray);
}

string resultSentence = string.Join(" ", output);
Console.WriteLine(resultSentence);
