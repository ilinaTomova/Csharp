using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write(" Enter a number a=");
        int a = int.Parse(Console.ReadLine());
        if (a >= 0 && a <= 500)
        {
            Console.Write("Enter a number b=");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter a number c=");
            float c = float.Parse(Console.ReadLine());
            string inHex = a.ToString("x");
            string inBin = Convert.ToString(a, 2);
            Console.Write("|{0,-10}", inHex);
            Console.Write("|{0,0}|", inBin);
            Console.Write("{0,10}|", Math.Round(b, 2));
            Console.WriteLine("{0,-10}|", Math.Round(c, 3));
        }
        else
        {
            Console.WriteLine("Interval number a - 0<= a<=500");
        }

    }
}

