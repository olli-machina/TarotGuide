using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : ScriptableObject
{
    public string cardName;
    public Sprite cardImage;
    public int cardIndex;
    public string cardText, cardNotes;

    public virtual void Open()
    {

    }

}