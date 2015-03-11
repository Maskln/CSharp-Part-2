/*Problem 3. Line numbers

Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.
*/

using System;
using System.Text;
using System.IO;
using System.Linq;


class LineNumbers
{
    static void Main()
    {
        string[] text = System.IO.File.ReadAllLines(@"../../text1.txt");
        string[] numberedText = text.Select((line, index) => (index + 1) + " - " + line).ToArray<string>();
        System.IO.File.WriteAllLines(@"../../text2.txt", numberedText);        
    }
}

