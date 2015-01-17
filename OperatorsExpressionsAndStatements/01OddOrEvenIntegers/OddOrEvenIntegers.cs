using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Write a number : ");
        int n = int.Parse(Console.ReadLine());
        bool isEven = n % 2 == 0;
        Console.WriteLine("The number is even - {0} ", isEven);
        
    
    }
}