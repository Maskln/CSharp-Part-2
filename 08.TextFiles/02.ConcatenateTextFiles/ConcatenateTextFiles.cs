/*Problem 2. Concatenate text files

Write a program that concatenates two text files into another text file.
*/

using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static void Main()
    {
        using (StreamWriter textThree = new StreamWriter(@"..\..\text3.txt", false))
        {
            using (StreamReader textOne = new StreamReader(@"..\..\text1.txt"))
            {
                string line = textOne.ReadLine();

                while (line != null)
                {
                    textThree.WriteLine(line);
                    line = textOne.ReadLine();
                }
            }

            using (StreamReader textTwo = new StreamReader(@"..\..\text2.txt"))
            {
                string line = textTwo.ReadLine();

                while (line != null)
                {
                    textThree.WriteLine(line);
                    line = textTwo.ReadLine();
                }
            }           
        }
    }
}

