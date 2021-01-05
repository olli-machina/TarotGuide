using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Deck> registeredDecks = new List<Deck>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddDeck(Deck newDeck)
    {
        registeredDecks.Add(newDeck);
    }

    public void DeleteDeck(Deck removeDeck)
    {
        registeredDecks.Remove(removeDeck); //check on this one
    }
}
