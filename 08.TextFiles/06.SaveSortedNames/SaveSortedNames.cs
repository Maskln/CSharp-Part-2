/*Problem 6. Save sorted names

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
*/

using System;
using System.Linq;
using System.Text;
using System.IO;


class SaveSortedNames
{
    static void Main()
    {
        string[] names = File.ReadAllLines(@"../../input.txt");
        string[] sortedNames = (from name in names orderby name select name).ToArray<string>();
        File.WriteAllLines("../../output.txt", sortedNames);        
    }
}

