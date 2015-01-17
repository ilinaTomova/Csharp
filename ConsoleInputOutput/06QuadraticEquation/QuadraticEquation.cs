using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter a number a, b and c in - ax2 + bx + c = 0");
        Console.Write("a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c:");
        double c = double.Parse(Console.ReadLine());
        
        double d = (b * b) - 4 * a * c;
        double D = Math.Sqrt(d);
        if (d < 0)
        {
            Console.WriteLine("No real roots");
        }
        else if (D == 0)
        {
            Console.WriteLine("There is one real x");
            double x = ((-b) / (2 * a));
            Console.WriteLine("x = {0}", x);
        }
        else if (D > 0)
        {
            Console.WriteLine("There are x1 and x2");
            double xFirst = ((-b - D) / (2 * a));
            Console.WriteLine("x1 = {0}", xFirst);
            double xSecond = ((-b + D) / (2 * a));
            Console.WriteLine("x = {0}", xSecond);


        }

    }
}

