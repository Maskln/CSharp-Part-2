/*Problem 14. Quick sort

Write a program that sorts an array of integers using the Quick sort algorithm.
*/

using System;


    class QuickSort
    {

        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static public void QuickSort_Recursive(int[] arr, int left, int right)
        {
           
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort_Recursive(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort_Recursive(arr, pivot + 1, right);
            }
        }

        static void Main()
        {
            Console.Write("Enter a value for a length of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("numbs[{0}] = ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The Sorted Array: ");
            QuickSort_Recursive(numbers, 0, n - 1);
            for (int i = 0; i < n; i++)
                Console.WriteLine("numbers[{0}] = {1}", i, numbers[i]);

            Console.WriteLine();

        }
    }


