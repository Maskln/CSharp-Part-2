/*Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
*/

using System;


class IndexOfLetters
{
    static void Main()
    {
        char[] letters = new char[26];

        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = Convert.ToChar(i + 65);
            Console.WriteLine("letters [{0}] = {1} ", i, letters[i]);
        }
        
        Console.WriteLine();
        
        Console.Write("Write a word: ");     
        string word = Console.ReadLine();
        Console.WriteLine();

        foreach (char symbol in word)
        {
            Console.WriteLine("Letter '{0}' = letter[{1}]", symbol, Array.IndexOf(letters, char.ToUpperInvariant(symbol)));

        }
    }

}
