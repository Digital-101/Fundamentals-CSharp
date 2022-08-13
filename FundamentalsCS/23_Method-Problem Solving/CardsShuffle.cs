using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._23_Method_Problem_Solving
{
    class CardsShuffle
    {
        static Random rand = new Random();

        static void MainCSM()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Face = "7", Suit = Suit.HEART });
            cards.Add(new Card() { Face = "A", Suit = Suit.SPADE });
            cards.Add(new Card() { Face = "10", Suit = Suit.DIAMOND });
            cards.Add(new Card() { Face = "2", Suit = Suit.CLUB });
            cards.Add(new Card() { Face = "6", Suit = Suit.DIAMOND });
            cards.Add(new Card() { Face = "J", Suit = Suit.CLUB });

            Console.Write("Initial Deck: ");
            PrintCards(cards);
            Console.WriteLine("-----------------------------------");
            ShuffleCards(cards);
            Console.Write("After Shuffle: ");
            PrintCards(cards);
        }


        private static void PerformSingleSwap(List<Card> cards, int index)
        {
            int randomIndex = rand.Next(0, cards.Count);
            Card firstCard = cards[index];
            Card randomCard = cards[randomIndex];
            cards[index] = randomCard;
            cards[randomIndex] = firstCard;
        }
        static void ShuffleCards(List<Card> cards)
        {
            if (cards.Count > 1)
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    PerformSingleSwap(cards, i);
                }
            }
        }
        private static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine();
        }
    }
}
