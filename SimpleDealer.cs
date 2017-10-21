using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Hands
{
    public class SimpleDealer
    {
        List<Card> cards = new List<Card>();
        List<Card> cardIndex = new List<Card>();
        //define slurped vars here:
        //Correct names:
        private readonly ICollection<Card> _availableCards;
        private readonly Random _random;
               
        public SimpleDealer()
        {
            //All Cards are contained here:
            _availableCards = CreateCards();
            _random = new Random();
        }

        public Card DealCard()
        {
            // Should check if any cards exist.
             var cardIndex = _random.Next(0, _availableCards.Count);
             var card = _availableCards.ElementAt(cardIndex);
            _availableCards.Remove(card);
            return card;
        }


        public ICollection<Card> CreateCards()
        {
            //var cards = new List<Card>();
            for (int i = 2; i <= 10; i++)
            {
                cards.Add(new Card(SuitType.Hearts, i));
                cards.Add(new Card(SuitType.Clubs, i));
                cards.Add(new Card(SuitType.Diamonds, i));
                cards.Add(new Card(SuitType.Spades, i));
                
                //HighCards created here:
                cards.Add(new Card(SuitType.Hearts, HighType.Jack));
                cards.Add(new Card(SuitType.Hearts, HighType.Queen));
                cards.Add(new Card(SuitType.Hearts, HighType.King));
                cards.Add(new Card(SuitType.Hearts, HighType.Ace));

                cards.Add(new Card(SuitType.Clubs, HighType.Jack));
                cards.Add(new Card(SuitType.Clubs, HighType.Queen));
                cards.Add(new Card(SuitType.Clubs, HighType.King));
                cards.Add(new Card(SuitType.Clubs, HighType.Ace));

                cards.Add(new Card(SuitType.Diamonds, HighType.Jack));
                cards.Add(new Card(SuitType.Diamonds, HighType.Queen));
                cards.Add(new Card(SuitType.Diamonds, HighType.King));
                cards.Add(new Card(SuitType.Diamonds, HighType.Ace));
                
                cards.Add(new Card(SuitType.Spades, HighType.Jack));
                cards.Add(new Card(SuitType.Spades, HighType.Queen));
                cards.Add(new Card(SuitType.Spades, HighType.King));
                cards.Add(new Card(SuitType.Spades, HighType.Ace));


            }
            return cards;
            
        }
    }
   
    public class Card
    {
        public readonly SuitType Suit;
        public readonly HighType High;
        public readonly int Value;
        
        public Card(SuitType suit, int value = 0)
        {
            Suit = suit;
            Value = value;
        }
        public string DisplayValue()
        {
            return $"{Suit.ToString()} {Value} {High.ToString()}";
        }
        public Card(SuitType suit, HighType high) 
        {
            Suit = suit;
            High = high;
        }
    }
   
    //make assigned val the same for later comparisons
    public enum SuitType
    {
        Hearts = 1,
        Clubs = 1,
        Diamonds = 1,
        Spades = 1
        
    }

    public enum HighType
    {
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }
}
//include interfaces? refer to reddit example https://www.reddit.com/r/csharp/comments/75qpsx/help_is_it_possible_to_create_generic_list_using/
