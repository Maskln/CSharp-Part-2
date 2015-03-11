/*Problem 7. Replace sub-string

Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).
*/

using System;
using System.Linq;
using System.Text;
using System.IO;


class ReplaceSubString
{
    static void Main()
    {
        using (StreamReader text = new StreamReader("../../text.txt")) //100MB.txt -> https://code.google.com/p/jquery-speedtest/downloads/detail?name=100MB.txt
        {
            using (StreamWriter result = new StreamWriter("../../output.txt"))
            {
                string line = string.Empty;
                while ((line = text.ReadLine()) != null)
                {
                    result.WriteLine(line.Replace("start", "finish"));
                }
            }
        }        
    }
}

