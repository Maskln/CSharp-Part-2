/*Problem 13. Count words

Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class CountWords
{
    static void Main()
    {
        try
        {
            string[] words = File.ReadAllLines("../../words.txt");
            string text = File.ReadAllText("../../text.txt");

            string[] wordsCountOutput = (from w in words                                
                                         let wordCount = Regex.Matches(text, w).Count   
                                         orderby wordCount descending                   
                                         select w + " - " + wordCount)                  
                                         .ToArray();                                    

            File.WriteAllText("../../results.txt", string.Join("\n", wordsCountOutput));
            
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (SecurityException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

