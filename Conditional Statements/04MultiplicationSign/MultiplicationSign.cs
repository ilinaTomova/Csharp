using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter a three real numbers : ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        #region 0
        if (a == 0 | b == 0 | c == 0)
        {
            Console.WriteLine("The result is 0!");
        }

        #endregion
        double abc = a * b * c;
        #region -
        if (abc < 0)
        {
            Console.WriteLine("The result is -");
        }
        #endregion
        #region +
        if (abc > 0)
        {
            Console.WriteLine("The result is +");
        }
        #endregion
    }
}

