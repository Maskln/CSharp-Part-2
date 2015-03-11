/*Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags
<a href="…">…</a> with corresponding tags [URL=…]…/URL].
*/

using System;


class ReplaceTags
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        input = input.Replace("<a href=\"", "[URL=");
        input = input.Replace("\">", "]");
        input = input.Replace("</a>", "[/URL]");

        Console.WriteLine(input);
    }
}

