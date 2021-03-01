using System;
using System.Threading;

namespace BlackJack
{
    abstract class Gamer
    {
        public int sum = 0;

        protected string name = "";
        public void Get(Card card)
        {
            Thread.Sleep(500);
            sum += (int)card.Value;
            Console.Write($"{name} берёт карту: ");
            Console.ForegroundColor = ((int)card.Suit < 2) ? ConsoleColor.Red: ConsoleColor.DarkGray;
            Console.WriteLine($"{(char)((int)card.Suit + 3)}{card.Value}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($@"Сумма {name} : {sum}");
            Console.CursorVisible = false;
        }
    }
}
