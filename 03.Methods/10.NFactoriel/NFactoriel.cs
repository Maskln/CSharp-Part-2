/*Problem 10. N Factorial

Write a program to calculate n! for each n in the range [1..100].
*/

using System;
using System.Numerics;

class NFactoriel
{
    static void Main()
    {
        for (int i = 0; i <= 100; i++)
        {
            BigInteger result = FactorielN(i);
            Console.WriteLine(result);
        }
    }

    static BigInteger FactorielN(int number)
    {
        BigInteger result = 1;
        int[] numbers = new int[number];

        for (int i = 0, j = 1; i < numbers.Length; i++, j++)
        {
            numbers[i] = j;
            result *= numbers[i];
        }
        return result;
    }
    
}



