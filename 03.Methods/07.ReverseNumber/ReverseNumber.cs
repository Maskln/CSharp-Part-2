/*Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a value: ");
        double valueN = double.Parse(Console.ReadLine());

        double reversed = ReverseValue(valueN);
        Console.WriteLine("Reversed Value = {0}", reversed);

    }

    static double ReverseValue(double number)
    {
        return double.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
    }
}

