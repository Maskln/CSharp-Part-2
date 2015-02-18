/*Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
*/

using System;


    class MaximalSequence
    {
        static void Main()
        {
            int currentPos = 1;
            int maxPos = 1;
            int arrayValue = 0;

            Console.Write("Enter a value for a length of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbs = new int[n];

            for (int i = 0; i < numbs.Length; i++)
            {
                Console.Write("numbs[{0}] = ", i);
                numbs[i] = int.Parse(Console.ReadLine());
            }

            
            for (int i = 0; i < n - 1; i++)
            {
                if (numbs[i] == numbs[i + 1])
                {
                    currentPos++;
                }
                else
                {
                    currentPos = 1;
                }

                if (currentPos >= maxPos)
                {
                    maxPos = currentPos;
                    arrayValue = numbs[i];
                }
            }

            for (int i = 0; i < maxPos; i++)
            {
                Console.Write("{0}, ", arrayValue);
            }
            Console.WriteLine();
        }
    }

