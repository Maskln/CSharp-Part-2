/*Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
find the smallest from the rest, move it at the second position, etc.
*/

using System;

    class SelectionSort
    {
        static void Main()
        {
            
            int temp;
             
            int iMin = 0;

            Console.Write("Enter a value for a length of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbs = new int[n];

            for (int l = 0; l < numbs.Length; l++)
            {
                Console.Write("numbs[{0}] = ", l);
                numbs[l] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < n - 1; j++)
            {
                iMin = j;
                for (int i = j + 1; i < n; i++)
                {
                    if (numbs[i] < numbs[iMin])
                    {
                        iMin = i;
                    }
                }
                if (iMin != j)
                {
                    temp = numbs[j];
                    numbs[j] = numbs[iMin];
                    numbs[iMin] = temp;
                }
            }


            for (int k = 0; k < n; k++)
            {
                Console.Write("{0}, ", numbs[k]);
            }
            Console.WriteLine();
        }
    }

