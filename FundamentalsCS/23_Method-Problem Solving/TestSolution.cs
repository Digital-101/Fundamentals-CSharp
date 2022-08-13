using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._23_Method_Problem_Solving
{
    class TestSolution
    {
        static void MainTS()
        {
            Card card = new Card() { Face = "A", Suit = Suit.CLUB };
            Console.WriteLine(card);
        }

        static void TestSwap()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Face = "2", Suit = Suit.CLUB });
            cards.Add(new Card() { Face = "3", Suit = Suit.HEART });
            cards.Add(new Card() { Face = "4", Suit = Suit.SPADE });
        }

        //Hard Common-Case Test
        static void TestShuffle52Cards()
        {
            List<Card> cards = new List<Card>();
            string[] allFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            Suit[] allSuits = new Suit[] { Suit.CLUB, Suit.DIAMOND, Suit.HEART, Suit.SPADE };
            foreach (string face in allFaces)
            {
                foreach (Suit suit in allSuits)
                {
                    Card card = new Card() { Face = face, Suit = suit };
                    cards.Add(card);
                }
            }
            //ShuffleCards(cards);
            //PrintCards(cards);
        }

        //Borderline Case Test
        static void TestShuffleOneCard()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Face = "A", Suit = Suit.CLUB });
            //CardsShuffle.ShuffleCards(cards);
            //CardsShuffle.PrintCards(cards);
        }

        static void TestShuffleTwoCards()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Face = "A", Suit = Suit.CLUB });
            cards.Add(new Card() { Face = "3", Suit = Suit.DIAMOND });
            //CardsShuffle(cards);
            //PrintShuffle(cards);
        }

        //Performance Test
        static void TestShuffle52000Cards()
        {
            List<Card> cards = new List<Card>();
            string[] allFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            Suit[] allSuits = new Suit[] { Suit.CLUB, Suit.DIAMOND, Suit.HEART, Suit.SPADE };
            for (int i = 0; i < 1000; i++)
            {
                foreach (string face in allFaces)
                {
                    foreach (Suit suit in allSuits)
                    {
                        Card card = new Card() { Face = face, Suit = suit };
                        cards.Add(card);
                    }
                }
            }
            //ShuffleCards(cards);
            //PrintCards(cards);

            //Test Time
            DateTime oldTime = DateTime.Now;
            //ShuffleCards(cards);
            DateTime newTime = DateTime.Now;
            Console.WriteLine("Execution Time: {0}", newTime-oldTime);
            //PrintCards(cards)

            //Results
            //Execution Time: 00:00:00.0059939
        }
    }
}
