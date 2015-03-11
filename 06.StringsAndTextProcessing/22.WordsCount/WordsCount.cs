/*Problem 22. Words count

Write a program that reads a string from the console and lists all different words
in the string along with information how many times each word is found.
*/

using System;
using System.Collections.Generic;
using System.Linq;

    class WordsCount
    {
        static void Main()
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine().Trim().ToLower();
            var nonLetterSymbols = new HashSet<char>();

            for (int i = 0; i < input.Length; i++) 
            {
                if (!char.IsLetter(input[i]))
                {
                    nonLetterSymbols.Add(input[i]);
                }
            }
            
            string[] words = input.Split(nonLetterSymbols.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> uniqueWords = new SortedSet<string>(words).ToList(); 
            var sortedUnique = new SortedDictionary<string, int>();  
           

            for (int i = 0; i < uniqueWords.Count; i++)
            {
                sortedUnique.Add(uniqueWords[i], 0);
            }

            for (int i = 0; i < words.Length; i++) 
            {
                sortedUnique[words[i]]++;
            }

            for (int i = 0; i < uniqueWords.Count; i++) 
            {
                Console.WriteLine("{0} -> {1}", uniqueWords[i], sortedUnique[uniqueWords[i]]);
            }

        }
    }

