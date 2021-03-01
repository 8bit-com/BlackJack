using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Deck
    {
        List<Card> arrList = new List<Card>();

        public Stack<Card> arr = new Stack<Card>();
        public Deck()
        {
            DeckInit();

            Shuffle<Card>(arrList);

            PushArr();
        }
        void PushArr()
        {
            foreach (var item in arrList)            
                arr.Push(item);            
        }
        void DeckInit()
        {
            Card card = new Card();

            for (Suit i = Suit.Picki; i < Suit.END; i++)
            {
                for (Value j = Value.Two; j < Value.Valet; j++)
                {
                    card.Suit = i;
                    card.Value = j;
                    arrList.Add(card);
                }
                card.Suit = i;
                card.Value = Value.Valet;
                arrList.Add(card);
                card.Suit = i;
                card.Value = Value.Dama;
                arrList.Add(card);
                card.Suit = i;
                card.Value = Value.Korol;
                arrList.Add(card);
                card.Suit = i;
                card.Value = Value.Tuz;
                arrList.Add(card);
            }
        }
        void Shuffle<T>(List<T> list)
        {
            Random rand = new Random();

            for (int i = list.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                T tmp = list[j];
                list[j] = list[i];
                list[i] = tmp;
            }
        }
    }
}
