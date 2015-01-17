using System;

class PrintTheASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        for (int i = 0; i<=255; i++)
        {
            char c = (char)i;
            Console.Write(c + " ");
        }

    }
}

