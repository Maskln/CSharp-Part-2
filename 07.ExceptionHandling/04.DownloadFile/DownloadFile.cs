/*Problem 4. Download file

Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
*/

using System;
using System.Net;
using System.IO;

class DownloadFile
{
    static void Main()
    {
        using (WebClient Client = new WebClient())
        {
            try
            {               
                Client.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "news-img01.png");
            }
            catch (ArgumentNullException anex)
            {
                Console.WriteLine(anex.Message);
            }
            catch (WebException webex)
            {
                Console.WriteLine(webex.Message);
            }
            catch (NotSupportedException nsuppex)
            {
                Console.WriteLine(nsuppex.Message);
            }
            finally
            {
                Console.WriteLine( "Exceptions are not found! Goodbye :)");
            }
            
        }
    }
}

