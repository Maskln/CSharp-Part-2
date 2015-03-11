/*Problem 1. Strings in C#.

Describe the strings in C#.
What is typical for the string data type?
Describe the most important methods of the String class
*/

using System;
using System.Text;

    class StringsInCSharp
    {
        static void Main()
        {
            StringBuilder infoString = new StringBuilder("A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only collection of Char objects. There is no null-terminating character at the end of a C# string; therefore a C# string can contain any number of embedded null characters ('\0'). The Length property of a string represents the number of Char objects it contains, not the number of Unicode characters. To access the individual Unicode code points in a string, use the StringInfo object.");
            infoString.Append("\n\nSome of most important methods:");
            infoString.Append("\n1) .IndexOf");
            infoString.Append("\n2) .Substring");
            infoString.Append("\n3) .ToUpper");
            infoString.Append("\n4) .Tolower");
            infoString.Append("\n5) .Split");
            infoString.Append("\n6) .Trim");
            infoString.Append("\n7) .Replace");
            infoString.Append("\n8) .Remove");
            Console.WriteLine(infoString.ToString());
        }
    }

