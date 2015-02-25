/*Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified
preliminary as array.
*/

using System;
using System.Linq;

class Workdays
{
    static void Main()
    {
        DateTime today = DateTime.Now;

        Console.Write("Enter a future date(yyyy/MM/dd): ");
        string userInput = Console.ReadLine();

        int[] date = userInput.Split('/').Select(int.Parse).ToArray();

        DateTime futureDate = new DateTime(date[0], date[1], date[2]);

        Console.WriteLine("{0} to {1}", today, futureDate);
        Console.WriteLine("The working days are: {0}", WorkingDays(today, futureDate));


    }

    static DateTime[] holydays = {
                                        new DateTime(2015, 1, 1), new DateTime(2015, 3, 3),
                                        new DateTime(2015, 5, 6), new DateTime(2015, 5, 24),
                                        new DateTime(2015, 9, 22), new DateTime(2015, 12, 24)
                                  };

    static int WorkingDays(DateTime today, DateTime futureDate)
    {
        int daysOfWork = 0;

        while (today <= futureDate)
        {
            if (!holydays.Contains(today) && today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday)
            {
                daysOfWork++;
            }
            today = today.AddDays(1);
        }




        return daysOfWork;
    }

}

