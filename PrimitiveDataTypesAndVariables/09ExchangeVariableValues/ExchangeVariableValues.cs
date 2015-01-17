using System;
class ExchangeVariableValues
{
    static void Main()
    {
        byte a = 5;
        byte b = 10;

        Console.WriteLine("a = {0} \nb = {1}", a, b);

        byte c = a;
        byte bSecond = c;
        byte aSecond = b;

        Console.WriteLine("if c = a, b = c, a = b,\nthen a = {0}, b = {1}", aSecond, bSecond);

    }
}

