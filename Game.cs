using static BlackJack.Const;
using System;

namespace BlackJack
{    
    class Game
    {
        public void Start()
        {
            play.Get(GetCard());
            play.Get(GetCard());
            play.More();

            if (play.sum < 22)
            {
                deal.GetMore();

                if (deal.sum < 22)
                {
                    if (deal.sum >  play.sum) Result(deal);
                    if (deal.sum <  play.sum) Result(play);                    
                    if (deal.sum == play.sum) Result(0);
                }
                else Result(play);
            }
            else Result(deal);
        }
        void Result(object obj)
        {
            Console.WriteLine($"\nДиллер: {deal.sum}");
            Console.WriteLine($"Игрок:  {play.sum}");
            Console.WriteLine(obj == play ? "Вы выиграли!": obj == deal ? "Вы проиграли :(" : "Ничья");
            Console.CursorVisible = false;
        }
    }
}
