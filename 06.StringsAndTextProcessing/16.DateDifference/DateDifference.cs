using System;
using System.Globalization;
using System.Text;
using System.Threading;

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter first date in the format(DD.MM.YYYY): ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine(), new CultureInfo("BG"));
        Console.WriteLine("Enter second date in the format day.month.year (ex: 21.2.2015): ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine(), new CultureInfo("BG"));
        TimeSpan days = secondDate - firstDate;
        var span = new StringBuilder();
        int i = 0;
        while (days.ToString()[i] != '.')
        {
            span.Append(days.ToString()[i]);
            i++;
        }
        int numberOfDays = Math.Abs(int.Parse(span.ToString()));
        Console.WriteLine("There are {0} days difference between {1:d.MM.yyyy} and {2:d.MM.yyyy}.", numberOfDays, firstDate, secondDate);
    }
}

