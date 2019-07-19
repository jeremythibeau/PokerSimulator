using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerSimulator
{
    class Deck
    {
        Card head;
        public int numcards;

        public Deck()
        {
            numcards = 0;
            head = null;
        }
        public void addCardBottom(int suit, int num)
        {
            //adds a new card to the deck at the bottom
            Card newcard = new Card(suit, num);
            numcards++;
            //if deck is empty
            if (head == null)
            {
                head = newcard;
                return;
            }
            //adds card to bottom of deck
            Card current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newcard;
        }
        public Card drawCard()
        {
            //if no cards in deck
            if (head == null) return null;
            //returns the top card and takes it from the deck
            Card drawnCard = head;
            head = head.next;
            numcards--;
            return drawnCard;
        }
        public Card pickCard(int number)
        {
            Card current = head;
            Card pickedCard;
            if(number == 1)
            {
                pickedCard = head;
                head = head.next;
                numcards--;
                return pickedCard;
            }
            Card previous = head;
            for (int i = 1; i <= number; i++)
            {
                previous = current;
                current = current.next;
            }
            previous.next = current.next;
            numcards--;
            return current;
        }
        public Deck Shuffle()
        {
            Random rand = new Random();
            Deck shuffledDeck = new Deck();
            int shufflenum = numcards;
            for (int i = 1; i <= shufflenum; i++)
            {
                int randCard = rand.Next(1, numcards);
                Card nextCard = pickCard(randCard);
                shuffledDeck.addCardBottom(nextCard.suit, nextCard.number);
            }
            return shuffledDeck;

        }
        public string printDeck()
        {
            string s = "";
            Card current = head;
            while(current != null)
            {
                s += current.printCard();
                current = current.next;
            }
            return s;
        }
    }
}
