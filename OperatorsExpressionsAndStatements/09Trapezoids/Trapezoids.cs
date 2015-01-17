using System;

class Trapezoids
{
    static void Main()
    {

        //S=0,5.(a+b)h
        Console.WriteLine(@"Enter a side ""a""");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine(@"Enter a side ""b""");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(@"Enter a heigh ""h""");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) * h) * 0.5;
        Console.WriteLine("The trapezoid's area is {0} ", area);


    
    }
}

