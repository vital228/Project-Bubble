using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Deck : MonoBehaviour
{

    public const int CARD_NUMBER = 36;
    const int SHUFFLE_NUMBER = 1;
    const int START_CARD_NUMBER = 6;

    public int lastCardNumber = -1;
    public bool endOfTheDeck = false;
    public Card[] card = new Card[36];
    private void Shuffle(int n)
    {
        Card c = new Card();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < CARD_NUMBER; j++)
            {
                int k = Random.Range(0, CARD_NUMBER - 1);
                c = card[k];
                card[k] = card[j];
                card[j] = c;
            }
        }
    }
    public Card GiveCard()
    {
        if (!endOfTheDeck)
        {
            lastCardNumber++;
            if (lastCardNumber == 35) endOfTheDeck = true;
            return card[lastCardNumber];
        }
        else return card[0];    // Сюда 100% не попадет, это нужно, чтобы не ругался.
    }

    void Start()
    {
        Shuffle(SHUFFLE_NUMBER);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
