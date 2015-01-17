using System;
class NullValuesArithmetic
{
    static void Main()
    {
        int? number1 = null;
        double? number2 = null;
        Console.WriteLine("{0};{1}", number1, number2);

        number1 = number1 + 10;
        number2 = number2 + 3000;

        Console.WriteLine("{0};{1}", number1, number2);
    }
}

