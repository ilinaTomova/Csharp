using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World!";
        object helloWorld = hello + " " + world;
        string both = (string)helloWorld;
        Console.WriteLine(both);

    }
}

