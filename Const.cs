namespace BlackJack
{
    enum Suit { Picki, Trefy, Bubi, Chervi, END = 4 }
    enum Value { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Valet = 10, Dama = 10, Korol = 10, Tuz = 11}
    public struct Card
    {
        Suit suit;

        Value value;
        internal Suit  Suit  { get => suit; set => suit = value; }
        internal Value Value { get => value; set => this.value = value; }
    }
    static class Const
    {
        public static Dealer deal;
        public static Player play;
        public static Deck deck;

        static Const()
        {
            deal = new Dealer();
            play = new Player();
            deck = new Deck();
        }
        public static Card GetCard()
        {
            return deck.arr.Pop();
        }
    }
}
