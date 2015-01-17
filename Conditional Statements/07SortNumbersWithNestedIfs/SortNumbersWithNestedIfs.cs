using System;

class SortNumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        #region  a
        if (a > b & a > c)
        {
            if (b >= c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            if (c > b )
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
        }

        #endregion
        #region b
        if (b > a & b > c)
        {
            if (a >= c )
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            if (c > a )
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }

        #endregion
        #region c
        if (c > a & c > b)
        {
            if (a >= b )
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            if (b > a)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }

        #endregion
    }
}

