using System;

class PrintSequence
{
    static void Main(string[] args)
    {
        for (int a = 2; a < 12; a++)
        {
            if (a % 2 == 0)
            {
                Console.Write("{0},", a);
            }
            else
            {
                Console.Write("{0},", -a);
            }
        }
        Console.WriteLine();
    }

}

