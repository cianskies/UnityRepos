using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField]private CardSlot _cardPrefab;
    [SerializeField]private Transform _cardPanel;
    [SerializeField]private List<CardSlot> _aviableCards;

    private int _index = 0;

    public int Index { get => _index; set => _index = value; }

    void Start()
    {
        

        //UpdateSelectedCard();
    }
    

    // Update is called once per frame
    void Update()
    {
        UpdateCardUI();
    }

    private void UpdateCardUI()
    {
        List<CardSO> cards= CardManager.Instance.Cards;
        //Debug.Log(cards.Count);
        for (int i = 0;i<cards.Count;++i)
        {
            UpdateCardInfo(cards[i], i);

        }
    }
    private void UpdateCardInfo(CardSO card, int index)
    {
        if(card != null)
        {
            CardSlot cardSlot;
            if (_aviableCards.Count <= index)
            {
                cardSlot = Instantiate(_cardPrefab, _cardPanel);
                _aviableCards.Add(cardSlot);
            }
            else
            {
                cardSlot = _aviableCards[index];
            }
                cardSlot.Index = index;
                cardSlot.Icon.sprite = card.Icon;
                cardSlot.ValueText.text = card.Card.Value.ToString();
                cardSlot.gameObject.SetActive(card.Aviable);


            


        }
    }

}
