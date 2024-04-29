using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card 
{
    [SerializeField]private CardSO _cardSO;
    [SerializeField]private int _value;
    private bool _aviable=true;

    public Card(CardSO cardSO, int value)
    {
        _cardSO=cardSO;
        _value=value;   
    }


    public CardSO CardData { get => _cardSO; set => _cardSO = value; }
    public int Value { get => _value; set => _value = value; }

    public bool Aviable { get=>_aviable; set => _aviable = value; }

    public void UseCard()
    {

    }

}
