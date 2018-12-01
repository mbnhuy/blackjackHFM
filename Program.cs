using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            string choice;
            string dealt_Card;
            while (true)
            {
                Console.WriteLine("Press 's' shuffle the deck of cards.");
                Console.WriteLine("Press 'd' deal the deck of cards.");
                Console.WriteLine("Press 'c' count current number of cards in the deck.");
                choice = Console.ReadLine();
                if(choice == "s")
                {
                    ShuffledDeck(myDeck);
                }
                if(choice == "d")
                {
                    dealt_Card = myDeck.Deal_Card();
                    Console.WriteLine(dealt_Card);
                    Console.WriteLine(myDeck.Card_Value(dealt_Card));
                }
                if(choice == "c")
                {
                    myDeck.CardsInStack();
                }
                Console.WriteLine();
            }
        }

        public static void ShuffledDeck(Deck myDeck)
        {
            myDeck.Shuffle_Deck();
            int count = 1;

            for (int i = 0; i < 52; i++, count++)
            {
                Console.Write("{0,  -10}", myDeck.ReturnCards(i));
                if ((count % 4) == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }


    }
}