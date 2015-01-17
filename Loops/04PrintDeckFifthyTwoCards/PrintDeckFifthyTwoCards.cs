using System;

class PrintDeckFifthyTwoCards
{
    static void Main()
    {

        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] cardsface = { "♠", "♥", "♣", "♦" };
        foreach (var card in cards)
        {
            foreach (var face in cardsface)
            {
                Console.Write("{0,3}{1}", card, face);
            }
            Console.WriteLine();
        }


    }
}

