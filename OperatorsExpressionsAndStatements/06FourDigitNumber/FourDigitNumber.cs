using System;
class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number : ");
        int number = int.Parse(Console.ReadLine());
        int a = (number / 1000) % 10;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = (number / 1) % 10;
        Console.WriteLine("The hole number is {0}, then \n a = {1} \n b = {2} \n c = {3} \n d = {4} ", number, a, b, c, d);

        int sum = a + b + c + d;
        Console.WriteLine("The sum is : {0}", sum);
        Console.WriteLine("The number in reversed order is : {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("If we put the last digit in first position, the result is : {0}{1}{2}{3} ", d, a, b, c);
        Console.WriteLine("If we change the second and the third digits, the result is : {0}{1}{2}{3}", a, c, b, d);


    }
}

