/*Problem 12. Remove words

Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;


    class RemoveWords
    {
        static void Main()
        {
            try
            {
                string[] wordsToRemove = File.ReadAllLines(@"../../text.txt");
                string text = File.ReadAllText(@"../../input.txt");

                foreach (string word in wordsToRemove)
                {
                    text = text.Replace(word, string.Empty);
                }

                File.WriteAllText("../../output.txt", text);                
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

