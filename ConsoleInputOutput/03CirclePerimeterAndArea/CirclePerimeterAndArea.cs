using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        // Числата ми работят с , не с . когато са дробни.

        Console.Write("Enter a radiur r:");
        decimal r = decimal.Parse(Console.ReadLine());
        decimal pI = 3.14159265358979323846M ;
        decimal area ;
        area = pI * (r * r);
        decimal perimeter;
        perimeter = pI * (2 * r);
        Console.WriteLine("The perimeter is : {0:0.00}", perimeter);
        Console.WriteLine("The area is : {0:0.00}", area);
        
    }
}

