/*Problem 11. Prefix "test"

Write a program that deletes from a text file all words that start with the prefix test.
Words contain only the symbols 0…9, a…z, A…Z, _.
*/

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;


    class Program
    {
        static void Main()
        {
            using (StreamReader streamReader = new StreamReader("../../text.txt"))
            {
                using (StreamWriter streamWriter = new StreamWriter("../../result.txt"))
                {
                    string line = streamReader.ReadLine();

                    while (line != null)
                    {
                        streamWriter.WriteLine(Regex.Replace(line, @"\bsub\w*\b", String.Empty));
                        line = streamReader.ReadLine();
                    }

                }
            }
        }
    }
    
