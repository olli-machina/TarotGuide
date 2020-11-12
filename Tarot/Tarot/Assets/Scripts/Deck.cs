using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : ScriptableObject
{
    public string deckName;
    public Sprite deckImage;
    public string deckType;

    public virtual void Open()
    {

    }

}