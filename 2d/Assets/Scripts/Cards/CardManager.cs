using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class CardManager : Singleton<CardManager>
{
    [SerializeField] private GameObject _prefabPlayer1;
    [SerializeField] private GameObject _prefabPlayer2;
    [SerializeField] private List<Card> _cards1 = new();
    [SerializeField] private List<Card> _cards2 = new();

    [SerializeField] private CardFamily[] _cardFamilyDB;

    
    private int _index;
    private int _index2;

    private PlayerAnimationController _animator1;
    private PlayerAnimationController _animator2;
    
    public List<CardSO> CardData(List<Card> cards) { 
        List<CardSO> cardSOs = new List<CardSO>();
            for (int i = 0; i < cards.Count; i++)
            {
                cardSOs.Add(cards[i].CardData);
            }
        
        return cardSOs;
        
    }
    public List<Card> Cards(int playerNum)
    {
        List<Card> cards;
        if(playerNum== 1)
        {
            cards=_cards1;
        }
        else
        {
            cards = _cards2;
        }
        return cards;
    }

    private void Start()
    {
        //Debug
        _cards1.Add(SearchCard("Fire", 0));
        _cards1.Add(SearchCard("Fire", 1));
        _cards1.Add(SearchCard("Attack", 1 ));
        _cards1.Add(SearchCard("Attack", 0));
        _cards1.Add(SearchCard("Fire", 2));
        
        _cards2.Add(SearchCard("Attack", 1 ));
        _cards2.Add(SearchCard("Attack", 0));
        _cards2.Add(SearchCard("Fire", 2));


        _index = 0;
        _index2 = 0;
        _animator1 = _prefabPlayer1.GetComponent<PlayerAnimationController>();
        _animator2 = _prefabPlayer2.GetComponent<PlayerAnimationController>();
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
            //Debug.Log(_cardFamilyDB[i].FamilyName);
            if (_cardFamilyDB[i].FamilyName == familyName)
            {
                newCard = _cardFamilyDB[i].SearchCardByValue(value);

                cardFound = true;
            }
        }

        return newCard;
    }
    public void addIndex(int add, List<Card> cards)
    {
        int aviableCardNum = getAviableCardNum(cards);
        if (aviableCardNum > 0)
        {
            Card oldCard;
            if (add > 0)
            {
                do
                {
                    oldCard = cards[_index];
                    cards.RemoveAt(_index);
                    cards.Add(oldCard);
                } while (!cards[_index].Aviable);

            }
            else
            {
                do
                {
                    for (int i = 0; i < cards.Count - 1; i++)
                    {
                        //Debug.Log(i);
                        Card card = cards[_index];
                        cards.RemoveAt(_index);
                        cards.Add(card);
                    }
                } while (!cards[_index].Aviable);

            }
        }


    }

    private int getAviableCardNum(List<Card> cards)
    {
        int aviableCardNum = 0;
        for (int i = 0; i < cards.Count; i++)
        {
            if (cards[i].Aviable)
            {
                ++aviableCardNum;
            }
        }

        return aviableCardNum;
    }

    private void UseCardPerformed(int playerNum)
    {
        List<Card> cards;
        int index;
        Card usedCard;
        Debug.Log(playerNum + " ha usado una carta");
        PlayerAnimationController animator;
        if (playerNum == 1)
        {
            cards = _cards1;
            index = _index;
            animator = _animator1;
        }
        else
        {
            cards= _cards2;
            index = _index2;
            animator = _animator2;
        }

            usedCard = cards[index];


            if (usedCard.CardData != null)
            {
                usedCard.UseCard();
            }
            else
            {
                Debug.Log("La carta no tiene ningun script de comportamiento asociada a esta");
            }
            //Debug.Log("Se usa " + usedCard.Name + " de valor " + usedCard.Value);
            animator.UseCardPerformedAnim(usedCard.CardData);
            usedCard.Aviable = false;
            addIndex(1, cards);

        

    }
    private void ReloadCards(int playerNum)
    {

        List<Card> cards;
        int index;

        if(playerNum == 1)
        {
            cards = _cards1;
            index = _index;
        }
        else
        {
            cards= _cards2;
            index = _index2;    
        }
        for (int i = 0; i < cards.Count; i++)
        {
            cards[i].Aviable = true;
 
        }
        index = 0;

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
    [SerializeField] private Card[] _cards;

    public string FamilyName { get => _familyName; set => _familyName = value; }
    public Card[] Cards { get => _cards; set => _cards = value; }
    
    public Card SearchCardByValue(int value)
    {
        Card newCard = null;
        bool cardFound = false;
        for (int i = 0; i < _cards.Length && !cardFound; i++)
        {
            
            //Debug.Log("Comprando con carta de valor "+value);
            if (_cards[i].Value == value)
            {
               
                //Debug.Log("Carta "+i+" encontrada");
                newCard = _cards[i];
                cardFound = true;
            }
        }
        if (newCard==null)
        {
            //Debug.Log("Nose ha encontrado la carta con valor "+value);
        }
        return newCard;
    }


}
