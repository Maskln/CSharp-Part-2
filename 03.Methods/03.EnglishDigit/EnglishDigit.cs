/*Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
*/

using System;


class EnglishDigit
{
    static void Main()
    {
        Console.Write("Enter an Integer: ");
        int valueN = int.Parse(Console.ReadLine());

        int lastDigit = valueN % 10;

        string result = IntAsWord(lastDigit);

        Console.WriteLine("The last digit in {0} is {1}!", valueN, result);



    }

    static string IntAsWord(int lastDigit)
    {
        string word = string.Empty;

        switch (lastDigit)
        {
            case 0: word = "zero"; break;
            case 1: word = "one"; break;
            case 2: word = "two"; break;
            case 3: word = "three"; break;
            case 4: word = "four"; break;
            case 5: word = "five"; break;
            case 6: word = "six"; break;
            case 7: word = "seven"; break;
            case 8: word = "eight"; break;
            case 9: word = "nine"; break;
        }
        return word;

    }

}


