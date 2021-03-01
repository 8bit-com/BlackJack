using static BlackJack.Const;

namespace BlackJack
{
    class Dealer : Gamer
    {
        public Dealer() => name = "Dealer";
        
        public void GetMore()
        {
            Get(GetCard());

            if (sum < 17) GetMore();
        }
    }
}
