using System;

    class CatalanNumbers
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            if (num > 0 && num < 31)
            {
                long numerator = 1;
                long denominator = 1;
                long result = 1;

                for (int k = 2; k <= num; k++)
                {
                    numerator *= (num + k);
                    if (numerator % k == 0)
                    {
                        numerator /= k;
                    }
                    else
                    {
                        denominator *= k;
                    }
                }
                result = numerator / denominator;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("out of range");
            }         
        }
    }

