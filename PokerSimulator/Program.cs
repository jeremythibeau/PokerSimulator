﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand p1Hand = new Hand();
            for(int x = 0; x < 4; x++)
            {
                for (int y = 1; y <= 13; y++)
                {
                    deck.addCardBottom(x, y);
                }
            }
            deck = deck.Shuffle();
            p1Hand.drawCard(deck.drawCard());
            p1Hand.drawCard(deck.drawCard());
            Console.WriteLine(p1Hand.printHand());
            Console.WriteLine("Number of cards in hand: {0}", p1Hand.numcards);
            Console.WriteLine("*****");
            Console.WriteLine(deck.printDeck());
            Console.WriteLine("Number of cards in deck: {0}", deck.numcards);
            Console.ReadKey();
        }
    }
}
