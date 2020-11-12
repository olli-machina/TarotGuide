using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckDataController : MonoBehaviour
{
    public Deck deck;


    private void Start()
    {
        UpdateInfo();
    }

    public void Open()
    {
        if (deck)
            Debug.Log(deck);
    }
 
    public void UpdateInfo()
    {
        Text deckName = transform.Find("Text").GetComponent<Text>();
        Image deckImage = transform.Find("Image").GetComponent<Image>();
            Debug.Log("Name: " + deckName + " Icon: " + deckImage);

        if(deck)
        {
            deckName.text = deck.deckName;
            deckImage.sprite = deck.deckImage;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

}
