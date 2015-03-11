/*Problem 1. Odd lines

Write a program that reads a text file and prints on the console its odd lines.
*/

using System;
using System.IO;
using System.Text;

class OddLines
{
    static void Main()
    {

        StreamReader textFile = new StreamReader("../../Text.txt", Encoding.UTF8);

        using (textFile)
        {
            int lineNumber = 0;
            string line = textFile.ReadLine();

            while (line != null)
            {
                lineNumber++;

                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("{0}: {1}", lineNumber, line);
                }

                line = textFile.ReadLine();
            }
        }
    }
}


