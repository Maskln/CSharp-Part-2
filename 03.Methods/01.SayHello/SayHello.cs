/*Problem 1. Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
*/

using System;

class SayHello
{
    public static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        SayHi(name);
    }


    public static void SayHi(string name)
    {

        Console.WriteLine("Hello, {0}!", name);


    }
}

