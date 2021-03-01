using System;
using static BlackJack.Const;
using static System.ConsoleKey;

namespace BlackJack
{
    class Player : Gamer
    {
        public Player() => name = "Player";

        public void More()
        {
            if (sum < 21)
            {
                Console.WriteLine("\nЕщё? (y/n)");

                ConsoleKey key = Enter;

                Console.Write("\b");

                while (key != Y && key != N)
                {
                    key = Console.ReadKey().Key;

                    Console.Write("\b");

                    if (key == Y) Get(GetCard());
                    if (key == N) break;
                }

                if(key == Y) More();
            }           
        }
    }
}
