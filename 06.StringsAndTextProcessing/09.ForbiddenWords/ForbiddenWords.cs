/*
We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
*/

using System;
using System.Text.RegularExpressions;

    class ForbiddenWords
    {
        static void Main()
        {
            Console.Write("Enter a text: ");
            string input = Console.ReadLine();
            Console.Write("Enter  forbidden words separated by comma: ");
            string sentence = Console.ReadLine();
            sentence = sentence.Trim();
            string[] forbiddenWords = sentence.Split(',', ' ');

            foreach (string word in forbiddenWords)
            {
                input = Regex.Replace(input, word, new String('*', word.Length));
            }

            Console.WriteLine("Output: " + input);
        }
    }

