using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers :");
        Console.Write("First number a =");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Second number b =");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("Third number c =");
        double thirdNum = double.Parse(Console.ReadLine());
        double sum = firstNum + secondNum + thirdNum;

        Console.WriteLine("The sum of the numbers : \n a + b + c = ? \n {0} + {1} + {2} = {3}",
            firstNum, secondNum, thirdNum, sum );

    }
}

