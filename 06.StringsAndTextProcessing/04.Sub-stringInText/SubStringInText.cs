/*Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine
is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
*/


using System;


class SubStringInText
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Enter the target Sub-String: ");
        string target = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("The Result is: {0}", FindSubStringInText(text, target));

    }

    private static int FindSubStringInText(string text, string target)
    {
        text = text.ToLower();
        target = target.ToLower();

        int count = 0;
        int index = text.IndexOf(target, 0);

        while (index >= 0)
        {
            count++;
            index++;
            index = text.ToLower().IndexOf(target, index);
        }

        return count;
    }
}

