using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter a number in decimal form : ");
        long decimalNum = long.Parse(Console.ReadLine());
        string binaryNum = Convert.ToString(decimalNum, 2).PadLeft(10, '0');
        Console.WriteLine(binaryNum);
    }
}

