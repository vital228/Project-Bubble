using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    const int MAX_HAND = 12;
    const int MIN_HAND = 6;
    public Deck deck;

    int handedCardsNumber = 0;
    Card[] hand = new Card[MAX_HAND];

    private void TakeCards()
    {
        for (int i = handedCardsNumber; i < MIN_HAND; i++)
        {
            if (!deck.endOfTheDeck)
            {
                handedCardsNumber++;
                hand[i] = deck.GiveCard();
            }
        }
    }
    public void ShowCards()
    {
        for(int i = 0; i < handedCardsNumber; i++)
        {
            Instantiate(hand[i], new Vector3(x: -i*1.5f, y: -3, z: 0), new Quaternion(0, 0, 0, 0));
            
        }
        /*
        public void CartNavigator(Card cart1, int n)
        {
            switch (n)
            {

                case 0:
                    
                    //cart1.transform.position = new Vector3(x: -3, y: -3, z: 0);
                    // cart1.transform.rotation = new Quaternion(45, 1, -20, 0);
                    break;
                case 1:
                    Instantiate(cart1, new Vector3(x: -1.5f, y: -3, z: 1), new Quaternion(0, 0, 0, 0));
                    // cart1.transform.position = new Vector3(x: -1.5f, y: -3, z: 0);
                    //cart1.transform.rotation = new Quaternion(45, 1, -10, 0);
                    break;
                case 2:
                    Instantiate(cart1, new Vector3(x: -0.5f, y: -3, z: 2), new Quaternion(0, 0, 0, 0));
                    //cart1.transform.position = new Vector3(x: -0.5f, y: -3, z: 0);
                    //cart1.transform.rotation = new Quaternion(45, 1, -5, 0);
                    break;
                case 3:
                    Instantiate(cart1, new Vector3(x: 0.5f, y: -3, z: 2), new Quaternion(0, 0, 0, 0));
                    //cart1.transform.position = new Vector3(x: 0.5f, y: -3, z: 0);
                    //cart1.transform.rotation = new Quaternion(45, 1, 5, 0);
                    break;
                case 4:
                    Instantiate(cart1, new Vector3(x: 1.5f, y: -3, z: 1), new Quaternion(0, 0, 0, 0));
                    //cart1.transform.position = new Vector3(x: 1.5f, y: -3, z: 0);
                    //cart1.transform.rotation = new Quaternion(45, 1, 10, 0);
                    break;
                case 5:
                    Instantiate(cart1, new Vector3(x: 3, y: -3, z: 0), new Quaternion(0, 0, 0, 0));
                    //cart1.transform.position = new Vector3(x: 3, y: -3, z: 0);
                    //cart1.transform.rotation = new Quaternion(45, 1, 20, 0);
                    break;
            }
        }
        */
    }

    // Use this for initialization
    public void Start()
    {
        handedCardsNumber = 0;
        TakeCards();
        ShowCards();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < handedCardsNumber; i++)
        {
            hand[i].transform.rotation = Quaternion.Euler(0, 0, 10);
        }
    }
}
