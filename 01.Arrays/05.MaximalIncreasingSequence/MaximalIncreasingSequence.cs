
/*Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
*/
 
using System;


    class MaximalIncreasingSequence
    {
        static void Main()
        {
            int currentPos = 1;
            int maxPos = 1;
            string currentValue = "";
            string highestValue = "";
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
                if (numbs[i] < numbs[i + 1])
                {
                    currentPos++;
                    currentValue += numbs[i] + ", ";
                }
                else
                {
                    if (currentPos > maxPos)
                    {
                        maxPos = currentPos;
                        currentValue += numbs[i] + ", ";
                        highestValue = currentValue;
                    }
                    currentPos = 1;
                    currentValue = "";
                }

               
            }

            if (currentPos > maxPos)
            {
                currentValue += numbs[numbs.Length - 1];
                highestValue = currentValue;
            }
            Console.WriteLine(highestValue);
        }
    }

