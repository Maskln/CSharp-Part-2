/*Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
*/

using System;
using System.Linq;

class SumIntegers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sequence of positive integers values separated by spaces!");
        string valuesInt = Console.ReadLine();
                
        Console.WriteLine("The sum is: {0}", SumOfValues(valuesInt));
        
    }

    static int SumOfValues(string valuesInt)
    {
        int sum = 0;

        int[] values = valuesInt.Split(' ').Select(int.Parse).ToArray();
              

        //foreach (int number in values)  // First way of calculation!
        //{
        //    sum += number;
        //}
        
        sum = values.Sum();           // Second way of calculation!
        
        return sum;
    }
}

