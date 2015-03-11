/*Problem 12. Parse URL

Write a program that parses an URL address given in the format:
[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
*/
using System;


class ParseURL
{
    static void Main()
    {
        Console.Write("Enter a URL: ");
        string input = Console.ReadLine();

        int serverIndex = input.IndexOf("://");
        int resIndex = input.Substring(serverIndex + 3).IndexOf("/") + serverIndex + 3;

        Console.WriteLine("[protocol] = " + input.Substring(0, serverIndex));
        Console.WriteLine("[server] = " + input.Substring(serverIndex + 3, resIndex - serverIndex - 3));
        Console.WriteLine("[resource] = " + input.Substring(resIndex));
    }
}

