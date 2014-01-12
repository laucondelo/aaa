using System;


namespace GameCards
{
    class TestCard
    {
        static void Main(string[] arg)
        {
            //Card card= new CircleCard(5);
            //card.PaintCard();
            CardDeck cardDeck=new CardDeck();

            for (int i = 1; i <= 13;i++ )
            {
                cardDeck.Cards.Add(new CircleCard(i));
                cardDeck.Cards.Add(new SquareCard(i));
                
            }

                
           //if (cardDeck.Cards.Count>0) 
                
            foreach (Card card in cardDeck.Cards)
            {
                card.PaintCard();
            }
            Console.Read();
        }
    }
}
