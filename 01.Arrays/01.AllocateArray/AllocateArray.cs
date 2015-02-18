/*Problem 1. Allocate array

Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.
*/

using System;


    class AllocateArray
    {
        static void Main()
        {
            int count = 20;
            int[] numbs = new int[count];

            for (int i = 0; i < numbs.Length; i++)
            {
                Console.WriteLine( "numbs[{0}] = {1}", i, numbs[i] = i * 5);
            } 
        }
    }

