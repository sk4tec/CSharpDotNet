using System;
class Program
{
    static void Main(string[] args)
    {
        int days = DaysLeft2(DateTime.Now, DateTime.Now.AddDays(55));
        Console.WriteLine(days);
    }

	static int DaysLeft(DateTime fromDate, DateTime toDate)
	{
        TimeSpan time =  toDate - fromDate;
        return (int)time.TotalDays;
	}

    static int DaysLeft2(DateTime fromDate, DateTime toDate)
	{
		int days = (int)toDate.Subtract(fromDate).TotalDays;

		if (days < 0)
		{
			days = 0;
		}

		return days;
	}
}
