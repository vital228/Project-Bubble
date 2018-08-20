using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Card
{
    public Sprite Borders, Logoranks,  Logotypes, Cards;
    public int Ranks, Types;

    public Card(string logotypes, string logoranks, string borders, string cards, int types, int ranks)
    {
        Borders = Resources.Load<Sprite>(borders);
        Logoranks = Resources.Load<Sprite>(logoranks);
        Logotypes = Resources.Load<Sprite>(logotypes);
        Cards = Resources.Load<Sprite>(cards);
        Ranks = ranks;
        Types = types;
    }

}

public static class CardManager
{
    public static List<Card> AllCards = new List<Card>();
}
public class CardManagerScr : MonoBehaviour {

    public void Awake()
    {
        CardManager.AllCards.Add(new Card("","",))
    }
	
}
