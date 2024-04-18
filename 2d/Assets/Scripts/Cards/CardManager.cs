using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardManager : Singleton<CardManager>
{
    [SerializeField] private List<Card> _cards = new();

    [SerializeField] private CardFamily[] _cardFamilyDB;

    private int _index;
    public List<CardSO> Cards { get { 
        List<CardSO> cardSOs = new List<CardSO>();
            for (int i = 0; i < _cards.Count-1; i++)
            {
                cardSOs.Add(_cards[0].CardData);
            }
        
        return cardSOs;
        } 
    }

    private void Start()
    {
        for (int i = 0; i < _cardFamilyDB.Length; i++)
        {
            _cardFamilyDB[i].SetCardValues();
        }

        //Debug
        //_cards.Add(SearchCard("Fire", 0));
        //_cards.Add(SearchCard("Fire", 1));
        _cards.Add(SearchCard("Attack", 1));
        _cards.Add(SearchCard("Attack", 0));
        //_cards.Add(SearchCard("Fire", 2));



        _index = 0;
        //for (int i = 0; i < _cards.Count; i++)
        //{
        //    Debug.Log("Card number " + i + " " + _cards[i].Name + " " + _cards[i].Value);
        //}

    }

    public Card SearchCard(String familyName, int value)
    {
        Card newCard = null;
        bool cardFound = false;
        for (int i = 0; i < _cardFamilyDB.Length && !cardFound; i++)
        {
            Debug.Log(_cardFamilyDB[i].FamilyName);
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
            Card oldCard;
            if (add > 0)
            {
                do
                {
                    oldCard = _cards[_index];
                    _cards.RemoveAt(_index);
                    _cards.Add(oldCard);
                } while (!_cards[_index].CardData.Aviable);

            }
            else
            {
                do
                {
                    for (int i = 0; i < _cards.Count - 1; i++)
                    {
                        //Debug.Log(i);
                        Card card = _cards[_index];
                        _cards.RemoveAt(_index);
                        _cards.Add(card);
                    }
                } while (!_cards[_index].CardData.Aviable);

            }
        }


    }

    private int getAviableCardNum()
    {
        int aviableCardNum = 0;
        for (int i = 0; i < _cards.Count; i++)
        {
            if (_cards[i].CardData.Aviable)
            {
                ++aviableCardNum;
            }
        }

        return aviableCardNum;
    }

    private void UseCardPerformed()
    {
        Card usedCard = _cards[_index];
        if(usedCard.CardData != null)
        {
            usedCard.UseCard();
        }
        else
        {
            Debug.Log("La carta no tiene ningun script de comportamiento asociada a esta");
        }


        //Debug.Log("Se usa " + usedCard.Name + " de valor " + usedCard.Value);
        usedCard.CardData.Aviable = false;
        addIndex(1);

    }
    private void ReloadCards()
    {
        for (int i = 0; i < _cards.Count; i++)
        {
            _cards[i].CardData.Aviable = true;
 
        }
        _index = 0;
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
    [SerializeField] private CardSO _baseCard;
    [SerializeField] private Card[] _cards;

    public string FamilyName { get => _familyName; set => _familyName = value; }
    public Card[] Cards { get => _cards; set => _cards = value; }
    
    public void SetCardValues()
    {
        for (int i = 0; i < _cards.Length; i++)
        {
            Debug.Log(i);
            _cards[i]= new Card(i);
          
            _cards[i].Value = i;
            
        }
        for (int i = 0; i < _cards.Length; i++)
        {
            Debug.Log(_cards[i].Value);

        }
    }

    public Card SearchCardByValue(int value)
    {
        Card newCard = null;
        bool cardFound = false;
        for (int i = 0; i < _cards.Length && !cardFound; i++)
        {
            Debug.Log(i);
            Debug.Log("Comprando con carta de valor "+value);
            if (_cards[i].Value == value)
            {
                newCard = _cards[i];
                cardFound = true;
            }
        }
        if (newCard==null)
        {
            Debug.Log("Nose ha encontrado la carta con valor "+value);
        }
        return newCard;
    }


}
