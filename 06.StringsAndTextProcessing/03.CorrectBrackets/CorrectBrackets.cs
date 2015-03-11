/*Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
*/

using System;


class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter an expression with brackets: ");
        string bracketsExpr = Console.ReadLine();

        if (CheckExpression(bracketsExpr))
        {
            Console.WriteLine("The brackets are placed correct!");
        }
        else
        {
            Console.WriteLine("The brackets are placed incorrect!");

        }

    }

    private static bool CheckExpression(string bracketsExpr)
    {
        bool IsCorrect = false;


        if (bracketsExpr[0] == ')')
        {
            IsCorrect = false;
        }

        int count = 0;
        foreach (char character in bracketsExpr)
        {
            if (character == '(')
            {
                ++count;
            }
            else if (character == ')')
            {
                --count;
            }
        }

        if (count == 0)
        {
            IsCorrect = true;
        }
        else
        {
            IsCorrect = false;
        }

        return IsCorrect;
    }


}

