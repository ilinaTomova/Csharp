using System;

class SumOfFiveNumbers
{
    static void Main()
    {

        Console.Write("Enter 5 numbers in a single line, separated by a space : ");
        string[] tokens = Console.ReadLine().Split();
        double a = double.Parse(tokens[0]);
        double b = double.Parse(tokens[1]);
        double c = double.Parse(tokens[2]);
        double d = double.Parse(tokens[3]);
        double e = double.Parse(tokens[4]);
        double sum = a + b + c + d + e;
        Console.WriteLine("The sum of numbers is : {0}", sum);
        

    }
}

