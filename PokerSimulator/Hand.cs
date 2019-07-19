using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerSimulator
{
    class Hand
    {
        Card head;
        public int numcards;

        public Hand()
        {
            head = null;
        }
        public void drawCard(Card c)
        {
            numcards++;
            if (head == null)
            {
                head = c;
                return;
            }
            Card current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = c;
        }
        public string printHand()
        {
            string s = "";
            Card current = head;
            while (current != null)
            {
                s += current.printCard();
                current = current.next;
            }
            return s;
        }
    }
}
