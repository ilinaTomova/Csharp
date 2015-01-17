using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.WriteLine("Write a number : ");
        int n = int.Parse(Console.ReadLine());
        bool devide = n % 5 == 0 && n % 7 == 0;
        Console.WriteLine(devide);
    }
}
