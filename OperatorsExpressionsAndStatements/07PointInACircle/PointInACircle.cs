using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Enter a point x :");        
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a point y :");   
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = (((x * x) + (y * y)) <= 2 * 2); 
        Console.WriteLine("The point is in the circle : {0}", isInCircle);
        
    }
}

