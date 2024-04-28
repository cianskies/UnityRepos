using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField]private CardSlot _cardPrefab;
    [SerializeField]private Transform _player1CardPanel;
    [SerializeField]private Transform _player2CardPanel;
    [SerializeField]private List<CardSlot> _player1AviableCards;
    [SerializeField]private List<CardSlot> _player2AviableCards;

    private int _index = 0;

    public int Index { get => _index; set => _index = value; }

    void Start()
    {
        

        //UpdateSelectedCard();
    }
    

    // Update is called once per frame
    void Update()
    {
        UpdateCardUI(1);
        UpdateCardUI(2);
    }

    private void UpdateCardUI(int playerNum)
    {
       

        List<Card> cards = CardManager.Instance.Cards(playerNum);
        List<CardSO> cardData = CardManager.Instance.CardData(cards);
        //Debug.Log(cards.Count);
        for (int i = 0;i<cardData.Count;++i)
        {
            UpdateCardInfo(cardData[i], cards[i], i, playerNum);

        }
    }
    private void UpdateCardInfo(CardSO cardData, Card card, int index, int playerNum)
    {
        if(cardData != null)
        {
            List<CardSlot> aviableCards;
            Transform cardPosition;

            if (playerNum == 1)
            {
                aviableCards=_player1AviableCards;
                cardPosition = _player1CardPanel;
            }
            else
            {
                aviableCards = _player2AviableCards;
                cardPosition = _player2CardPanel;
            }
            CardSlot cardSlot;
            if (aviableCards.Count <= index)
            {

                cardSlot = Instantiate(_cardPrefab, cardPosition);
                aviableCards.Add(cardSlot);

            }
            else
            {
                cardSlot = aviableCards[index];
            }
                cardSlot.Index = index;
                cardSlot.Icon.sprite = cardData.Icon;
            //Debug.Log(card.Value +"se updatea en la ui");
                cardSlot.ValueText.text = card.Value.ToString();
                cardSlot.gameObject.SetActive(card.Aviable);


            


        }
    }

}
