using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Write weight on Earth : ");
        double earthWeight = double.Parse(Console.ReadLine());
        double moonWeight = earthWeight * 0.17;
        Console.WriteLine("The weight on the Moon is : {0}", moonWeight);

    }
}

