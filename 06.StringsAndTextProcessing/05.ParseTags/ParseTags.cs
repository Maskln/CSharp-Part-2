/*Problem 5. Parse tags

You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
*/

using System;


class ParseTags
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();

        Console.WriteLine(ChangeTheTextBetweenTheTags(text));
         
    }

    private static string ChangeTheTextBetweenTheTags(string text)
    {
        while (text.IndexOf("<upcase>") != -1)
        {
                        
            int indexOfBegining = text.IndexOf("<upcase>");
            int indexOfEnding = text.IndexOf("</upcase>");
            string tempText = text.Substring(indexOfBegining + "<upcase>".Length, indexOfEnding - indexOfBegining - "<upcase>".Length);
            
            text = text.Replace("<upcase>" + tempText + "</upcase>", tempText.ToUpper());
                      
        }
        return text;       
    }
}