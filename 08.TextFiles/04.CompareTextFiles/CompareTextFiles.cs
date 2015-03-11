/*Problem 4. Compare text files

Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.
*/

using System;
using System.Linq;
using System.Text;


class CompareTextFiles
{
    static void Main()
    {
        string[] text1 = System.IO.File.ReadAllLines(@"../../text1.txt");
        string[] text2 = System.IO.File.ReadAllLines(@"../../text2.txt");

        int textEqual = text1.Where((line, index) => line == text2[index]).Count();

        Console.WriteLine("There are {0} different row(s)!", (text2.Length - textEqual));
    }
}

