using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackV2._0
{
    internal class Deck
    {
        const int NumCards = 52;
        public List<Card> deck;

        public Deck()

        {

            deck = new List<Card>()
            {
                new Card() { rank = 2, suit = "Two Spades", image = "../../Images/2_of_spades.png" },
                new Card() { rank = 3, suit = "Three Spades", image = "../../Images/3_of_spades.png" },
                new Card() { rank = 4, suit = "Four Spades", image = "../../Images/4_of_spades.png" },
                new Card() { rank = 5, suit = "Five Spades", image = "../../Images/5_of_spades.png" },
                new Card() { rank = 6, suit = "Six Spades", image = "../../Images/6_of_spades.png" },
                new Card() { rank = 7, suit = "Seven Spades", image = "../../Images/7_of_spades.png" },
                new Card() { rank = 8, suit = "Eight Spades", image = "../../Images/8_of_spades.png" },
                new Card() { rank = 9, suit = "Nine Spades", image = "../../Images/9_of_spades.png" },
                new Card() { rank = 10, suit = "Ten Spades", image = "../../Images/10_of_spades.png" },
                new Card() { rank = 10, suit = "Jack Spades", image = "../../Images/jack_of_spades.png" },
                new Card() { rank = 10, suit = "Queen Spades", image = "../../Images/queen_of_spades.png" },
                new Card() { rank = 10, suit = "King Spades", image = "../../Images/king_of_spades.png" },
                new Card() { rank = 11, suit = "Ace Spades", image = "../../Images/ace_of_spades.png" },

                new Card() { rank = 2, suit = "Two Diamonds", image = "../../Images/2_of_diamonds.png" },
                new Card() { rank = 3, suit = "Three Diamonds", image = "../../Images/3_of_diamonds.png" },
                new Card() { rank = 4, suit = "Four Diamonds", image = "../../Images/4_of_diamonds.png" },
                new Card() { rank = 5, suit = "Five Diamonds", image = "../../Images/5_of_diamonds.png" },
                new Card() { rank = 6, suit = "Six Diamonds", image = "../../Images/6_of_diamonds.png" },
                new Card() { rank = 7, suit = "Seven Diamonds", image = "../../Images/7_of_diamonds.png" },
                new Card() { rank = 8, suit = "Eight Diamonds", image = "../../Images/8_of_diamonds.png" },
                new Card() { rank = 9, suit = "Nine Diamonds", image = "../../Images/9_of_diamonds.png" },
                new Card() { rank = 10, suit = "Ten Diamonds", image = "../../Images/10_of_diamonds.png" },
                new Card() { rank = 10, suit = "Jack Diamonds", image = "../../Images/jack_of_diamonds.png" },
                new Card() { rank = 10, suit = "Queen Diamonds", image = "../../Images/queen_of_diamonds.png" },
                new Card() { rank = 10, suit = "King Diamonds", image = "../../Images/king_of_diamonds.png" },
                new Card() { rank = 11, suit = "Ace Diamonds", image = "../../Images/ace_of_diamonds.png" },

                new Card() { rank = 2, suit = "Two Clubs", image = "../../Images/2_of_clubs.png" },
                new Card() { rank = 3, suit = "Three Clubs", image = "../../Images/3_of_clubs.png" },
                new Card() { rank = 4, suit = "Four Clubs", image = "../../Images/4_of_clubs.png" },
                new Card() { rank = 5, suit = "Five Clubs", image = "../../Images/5_of_clubs.png" },
                new Card() { rank = 6, suit = "Six Clubs", image = "../../Images/6_of_clubs.png" },
                new Card() { rank = 7, suit = "Seven Clubs", image = "../../Images/7_of_clubs.png" },
                new Card() { rank = 8, suit = "Eight Clubs", image = "../../Images/8_of_clubs.png" },
                new Card() { rank = 9, suit = "Nine Clubs", image = "../../Images/9_of_clubs.png" },
                new Card() { rank = 10, suit = "Ten Clubs", image = "../../Images/10_of_clubs.png" },
                new Card() { rank = 10, suit = "Jack Clubs", image = "../../Images/jack_of_clubs.png" },
                new Card() { rank = 10, suit = "Queen Clubs", image = "../../Images/queen_of_clubs.png" },
                new Card() { rank = 10, suit = "King Clubs", image = "../../Images/king_of_clubs.png" },
                new Card() { rank = 11, suit = "Ace Clubs", image = "../../Images/ace_of_clubs.png" },

                new Card() { rank = 2, suit = "Two Hearts", image = "../../Images/2_of_hearts.png" },
                new Card() { rank = 3, suit = "Three Hearts", image = "../../Images/3_of_hearts.png" },
                new Card() { rank = 4, suit = "Four Hearts", image = "../../Images/4_of_hearts.png" },
                new Card() { rank = 5, suit = "Five Hearts", image = "../../Images/5_of_hearts.png" },
                new Card() { rank = 6, suit = "Six Hearts", image = "../../Images/6_of_hearts.png" },
                new Card() { rank = 7, suit = "Seven Hearts", image = "../../Images/7_of_hearts.png" },
                new Card() { rank = 8, suit = "Eight Hearts", image = "../../Images/8_of_hearts.png" },
                new Card() { rank = 9, suit = "Nine Hearts", image = "../../Images/9_of_hearts.png" },
                new Card() { rank = 10, suit = "Ten Hearts", image = "../../Images/10_of_hearts.png" },
                new Card() { rank = 10, suit = "Jack Hearts", image = "../../Images/jack_of_hearts.png" },
                new Card() { rank = 10, suit = "Queen Hearts", image = "../../Images/queen_of_hearts.png" },
                new Card() { rank = 10, suit = "King Hearts", image = "../../Images/king_of_hearts.png" },
                new Card() { rank = 11, suit = "Ace Hearts", image = "../../Images/ace_of_hearts.png" }
            };
        }


        public void Shuffle()
        {
            //Create shuffle method using random
            Random rand = new Random();
            Card temp;

            //Run the shuffle 50 times
            for (int shuffletimes = 0; shuffletimes < 50; shuffletimes++)
            {
                for (int i = 0; i < NumCards; i++)
                {
                    //Swap the cards
                    int secondCardIndex = rand.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;

                }
            }
        }
        //Create remove card method by removing the top card from list deck
        public void RemoveCard()
        {
            deck.RemoveAt(0);
        }
        //Create deal method to list players
        public void PlayerDeal(Player player)
        {
            for (int j = 0; j < 2; j++)
            {
                player.AddCard(deck[0]);
                RemoveCard();
            }
        }

        public void DealerDeal(Dealer dealer)
        {
            for (int d = 0; d < 1; d++)
            {
                dealer.DealerAddCard(deck[0]);
                RemoveCard();
            }
          
        }
        public Card GetAndRemoveCard()
        {
            Card card = deck[0];
            RemoveCard();
            return card;
        }
    }
}
