/*
5 rules of Functional:

1) Pure functions - Can't do anything but the function, can't log to console for example
2) Immutability - Can't change the object, have to return a new object
3) Statelessness - Can't hold state, can't reference Statics or Globals etc
4) Recusrsion  - As we can't hold state, we use Recursion to process a list of objects
5) Functional Composition - We chain pure functions together (like in Combine) to solve problems.
*/

using System;
class Program
{
    static void Main()
    {
        DoubleItAndAddOne();
        DoubleAllInList();
    }

    static void DoubleItAndAddOne()
    {
        Func<int, int> AddOne = n => n + 1;
        Func<int, int> DoubleIt = n => n * 2;
    
        Console.WriteLine("Double it and add 1");
        Console.WriteLine(AddOne(DoubleIt(5)));
    }

    static void DoubleAllInList() 
    {
        List<int> numbers = new List<int> {1, 2, 3, 4, 5};

        var doubledNumbers = numbers.Select(n => n * 2).ToList();        
        var filtereredNumbers = numbers.Where( n => n > 3).ToList();

        Console.WriteLine("Double All In List");
        foreach(var number in doubledNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Filter numbers over 3");
        filtereredNumbers.ForEach(n => Console.WriteLine(n));
    }
}