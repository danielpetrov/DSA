using System;
using System.Collections.Generic;

public class StartUp
{
     public static void Main()
     {
        List<Card> listOfCards = new List<Card>();
         Deck deck = new Deck();
        listOfCards.Add(deck.GetNextCard());
        listOfCards.Add(deck.GetNextCard());
        listOfCards.Add(deck.GetNextCard());
        listOfCards.Add(deck.GetNextCard());
        
        List<PlayingCard> playingCards = new List<PlayingCard>();

        foreach (var card in listOfCards)
        {
            Console.WriteLine(card);
            playingCards.Add(new PlayingCard(CardSuit.Club, card.Type));
        }
        
        playingCards.Add(new PlayingCard(CardSuit.Club, CardType.Five));
        playingCards.Add(new PlayingCard(CardSuit.Club, CardType.Ace));
        playingCards.Add(new PlayingCard(CardSuit.Club, CardType.Six));
        playingCards.Add(new PlayingCard(CardSuit.Club, CardType.Seven));
        playingCards.Add(new PlayingCard(CardSuit.Spade, CardType.Eight));
        playingCards.Add(new PlayingCard(CardSuit.Club, CardType.Nine));
        playingCards.Add(new PlayingCard(CardSuit.Club, CardType.King));
        playingCards.Sort();
        foreach (var card in playingCards)
        {
            Console.WriteLine(card.NominalValue);
            //playingCards.Add(new PlayingCard(CardSuit.Club, card.Type));
        }
        //playingCards.Add(new PlayingCard(CardSuit.Diamond, CardType.Ten));
        //playingCards.Add(new PlayingCard(CardSuit.Club, CardType.Five));
        //playingCards.Add(new PlayingCard(CardSuit.Club, CardType.Six));
        //playingCards.Sort();
        HandEvaluateRaiseTwo pk = new HandEvaluateRaiseTwo();
        if (pk.Rules[PokerHands.Pair](playingCards))
        {
            Console.WriteLine("pair");
        }

        if (pk.Rules[PokerHands.TwoPair](playingCards))
        {
            Console.WriteLine("twoPair");
        }

        if (pk.Rules[PokerHands.Flush](playingCards))
        {
            Console.WriteLine("flush");
        }
        if (pk.Rules[PokerHands.Straight](playingCards))
        {
            Console.WriteLine("straigth");
        }
    }
}

