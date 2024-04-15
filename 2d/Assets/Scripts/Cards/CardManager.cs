using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : Singleton<CardManager>
{
    [SerializeField] private Card[] _cards;

    [SerializeField] private CardFamily[] _cardFamilyDB;

    public Card[] Cards { get { return _cards; } }

    private void Start()
    {
        _cards[0].CardData= SearchCard("Fire", 1);
        _cards[1].CardData = SearchCard("Fire", 2);
        _cards[2].CardData = SearchCard("Attack", 0);

        for (int i = 0; i < _cards.Length; i++)
        {
            Debug.Log("Card number "+i+" "+_cards[i].CardData.Name + " " + _cards[i].CardData.Value);
        }
        
    }

    public CardSO SearchCard(String familyName, int value)
    {
        CardSO newCard = null;
        bool cardFound = false;
        for (int i = 0; i < _cardFamilyDB.Length && !cardFound; i++)
        {
            if (_cardFamilyDB[i].FamilyName == familyName)
            {
                newCard= _cardFamilyDB[i].SearchCardByValue(value);

                cardFound = true;
            }
        }
        
        return newCard;
    }


}
[Serializable]
public class CardFamily
{
    [SerializeField] private string _familyName;
    [SerializeField] private CardSO[] _cards;

    public string FamilyName { get => _familyName; set => _familyName = value; }
    public CardSO[] Cards { get => _cards; set => _cards = value; }

    public CardSO SearchCardByValue(int value)
    {
        CardSO newCard=null;
        bool cardFound = false;
        for (int i = 0; i < Cards.Length && !cardFound; i++)
        {
            if  (Cards[i].Value==value)
            {
                newCard = Cards[i];
                cardFound = true;
            } 
        }
        return newCard;
    }
}
