using System;

namespace BlackJack
{
    class Program
    {
        static void Main()
        {
            Game game = new Game();
            game.Start();
            Console.ReadKey();
        }
    }
}