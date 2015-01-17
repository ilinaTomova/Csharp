using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height:");
        double height = double.Parse(Console.ReadLine());

        // Perimeter : P = 2a + 2b = 2.(a + b)
        // Area :  S = a.b
        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine("The perimeter is : {0}" , perimeter);
        Console.WriteLine("The area is : {0}" , area);


    }
}

