using System;

    class FloatOrDouble
    {
        static void Main()
        {
            //34.567839023, 12.345, 8923.1234857, 3456.091
            double firstNum = 34.567839023d;
            float secondNum = 12.345f;
            double thirdNum = 8923.1234857d;
            float fourthNum = 3456.091f;
            Console.WriteLine("{0} and {1} are double", firstNum, thirdNum);
            Console.WriteLine("{0} and {1} are float", secondNum, fourthNum);

        }
    }
