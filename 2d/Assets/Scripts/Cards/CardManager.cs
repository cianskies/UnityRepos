using System;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : Singleton<CardManager>
{
    [SerializeField] private List<CardSO> _cards = new();

    [SerializeField] private CardFamily[] _cardFamilyDB;

    private int _index;
    public List<CardSO> Cards { get { return _cards; } }

    private void Start()
    {
        _index = 0;
        _cards.Add(SearchCard("Fire", 0));
        _cards.Add(SearchCard("Fire", 1));
        _cards.Add(SearchCard("Attack", 1));
        _cards.Add(SearchCard("Attack", 0));
        _cards.Add(SearchCard("Fire", 2));




        for (int i = 0; i < _cards.Count; i++)
        {
            Debug.Log("Card number " + i + " " + _cards[i].Name + " " + _cards[i].Value);
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
                newCard = _cardFamilyDB[i].SearchCardByValue(value);

                cardFound = true;
            }
        }

        return newCard;
    }
    public void addIndex(int add)
    {
        int aviableCardNum = getAviableCardNum();
        if (aviableCardNum > 0)
        {
            CardSO oldCard;
            if (add > 0)
            {
                do
                {
                    oldCard = _cards[_index];
                    _cards.RemoveAt(_index);
                    _cards.Add(oldCard);
                } while (!_cards[_index].Aviable);

            }
            else
            {
                do
                {
                    for (int i = 0; i < _cards.Count - 1; i++)
                    {
                        //Debug.Log(i);
                        CardSO card = _cards[_index];
                        _cards.RemoveAt(_index);
                        _cards.Add(card);
                    }
                } while (!_cards[_index].Aviable);

            }
        }


    }

    private int getAviableCardNum()
    {
        int aviableCardNum = 0;
        for (int i = 0; i < _cards.Count; i++)
        {
            if (_cards[i].Aviable)
            {
                ++aviableCardNum;
            }
        }

        return aviableCardNum;
    }

    private void UseCardPerformed()
    {
        _cards[_index].Aviable = false;
        addIndex(1);

    }
    private void ReloadCards()
    {
        for (int i = 0; i < _cards.Count; i++)
        {
            _cards[i].Aviable = true;
        }
    }
    private void OnEnable()
    {
        PlayerMovementController.UseCardEvent += UseCardPerformed;
        PlayerMovementController.ReloadCardsEvent += ReloadCards;
    }
    private void OnDisable()
    {
        PlayerMovementController.UseCardEvent -= UseCardPerformed;
        PlayerMovementController.ReloadCardsEvent -= ReloadCards;
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
        CardSO newCard = null;
        bool cardFound = false;
        for (int i = 0; i < Cards.Length && !cardFound; i++)
        {
            if (Cards[i].Value == value)
            {
                newCard = Cards[i];
                cardFound = true;
            }
        }
        return newCard;
    }


}
