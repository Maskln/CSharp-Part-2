/*Problem 3. Read file contents

Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
*/

using System;
using System.IO;


class ReadFileContents
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a full path of the file: ");
            string path = Console.ReadLine();
            Console.WriteLine(File.ReadAllText(path));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ptlx)
        {
            Console.WriteLine(ptlx.Message);
        }
        catch (IOException io)
        {
            Console.WriteLine(io.Message);
        }
        catch (UnauthorizedAccessException unex)
        {
            Console.WriteLine(unex.Message);
        }
        catch (NotSupportedException nsupex)
        {
            Console.WriteLine(nsupex.Message);
        }


    }
}

