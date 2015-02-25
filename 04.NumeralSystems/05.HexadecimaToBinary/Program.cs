/*Problem 5. Hexadecimal to binary

Write a program to convert hexadecimal numbers to binary numbers (directly).
*/

using System;


class HexadecimaToBinary
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hex = Console.ReadLine().ToUpper();

        Console.WriteLine("{0} = {1}", hex, HexaDecToBin(hex));
    }

    static string HexaDecToBin(string hex)
    {
        string binary = "";

        for (int i = 0; i < hex.Length; i++)
        {
            if (Char.IsDigit(hex[i]))
            {
                binary += Convert.ToString(int.Parse(hex[i].ToString()), 2).PadLeft(4, '0');
            }
            else
            {
                binary += Convert.ToString((hex[i] - 'A' + 10), 2).PadLeft(4, '0');
            }
        }
        return binary.TrimStart('0');
    }
}
