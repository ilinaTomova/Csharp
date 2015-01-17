using System;

class MinMaxSumAndAverageNNumbers
{
    static void Main()
    {
        double n = int.Parse(Console.ReadLine());
        double max = int.MinValue;
        double min = int.MaxValue;
        double sum = 0;
        double avg = 0;
        for (double i = 1; i <= n; i++)
        {
            double variable = int.Parse(Console.ReadLine());
            if (variable > max)
            {
                max = variable;
                            }
            if (variable < min)
            {
                min = variable;
            }
            sum += variable;
                        
        }
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avr = {0:F2}", avg = sum / n);
       
    }
}

