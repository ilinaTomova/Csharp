using System;

class SumOfNumbers
{
    static void Main()
    {
        
        //Console.Write("Enter a number of numbers n =");
        //long n = long.Parse(Console.ReadLine());
        //decimal sum = 0.00m;
        //decimal number = decimal.MinValue;
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine("Enter numbers : ");
        //    number = decimal.Parse(Console.ReadLine());
        //    sum += number;
        //}
        //Console.WriteLine("The sum is {0}" , sum);
       
        Console.WriteLine("Enter numbers n =");
        double n = double.Parse(Console.ReadLine());
        double sum = 0;
        double number = 0;
        for (double i = 0; i < n; i ++ )
        {
             number = double.Parse(Console.ReadLine());
             sum += number;
            
        }
        Console.WriteLine(sum);



    }
}

