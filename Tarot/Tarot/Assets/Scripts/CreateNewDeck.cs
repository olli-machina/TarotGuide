using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewDeck : MonoBehaviour
{
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddDeck(int size, string name, Sprite image, string type)
    {
        Deck newDeck = new Deck(); //figure this out ("new")
        if (image != null)
        {
            newDeck.deckImage = image;
        }

        newDeck.deckName = name;
        newDeck.deckType = type;
        newDeck.deckSize = size;

        gameManager.AddDeck(newDeck);
    }

    public void AddCard(string name, Sprite image, int index, string text, string notes, Deck deck)
    {
        List<Card> cardSet = new List<Card>();
        for (int i = 0; i < index; i++) //do I want to keep the index?
        {
            Card newCard = new Card(); //figure this out ("new")
            if (image != null)
            {
                newCard.cardImage = image;
            }
            if(notes != null)
            {
                newCard.cardNotes = notes;
            }
            
            newCard.cardName = name;
            newCard.cardIndex = index;
            newCard.cardText = text;

            cardSet.Add(newCard);
        }

        deck.cards = cardSet;
    }
}
