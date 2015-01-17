using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.WriteLine("Enter a number : ");
        int number = Math.Abs(int.Parse(Console.ReadLine()));
        bool result = (number / 100) % 10 == 7;
        Console.WriteLine(result);
    }
}
