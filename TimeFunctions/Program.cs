// See https://aka.ms/new-console-template for more information
// This coding challenge will see you pass in the hours, minutes and seconds into a method and 
// convert it to a time formatted string.
// Include leading zeros on the minutes and seconds (but not the hours). So if you pass in hours = 1, minutes = 3 and seconds = 8, the function should return 1:03:08.
// If the hours you pass in is 0, it should still return the number of hours as part of the string. So if you pass in hours = 0, minutes = 34 and seconds = 1, the function should return 0:34:01.

using System;

class Program
{
    static void Main(string[] args)
    {
        var val =ConvertToTimeString(1, 32, 33);
        Console.WriteLine($"val {val}");

        var val2 =ConvertToTimeString(0, 32, 01);
        Console.WriteLine($"va2 {val2}");
    }

    static string ConvertToTimeString(int hours, int minutes, int seconds)
    {
        if (
            hours < 0 || 
            minutes < 0 || 
            minutes > 59 || 
            seconds < 0 || 
            seconds > 59
            )
        {
            throw new ArgumentOutOfRangeException("Invalid parameters");
        }

        // ToString("00"): This method converts the integer to a string, ensuring that it is formatted with at least two digits.
        // If the value of minutes is less than 10, it will add a leading zero.

        return $"{hours.ToString()}:{minutes.ToString("00")}:{seconds.ToString("00")}";
    }
}
