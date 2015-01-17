using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a number in decimal form : ");
        long decimalNum = long.Parse(Console.ReadLine());
        string hexadecimalNum = decimalNum.ToString("X");
        Console.WriteLine("The number in hexadecimal form is : {0}", hexadecimalNum);
    }
}

