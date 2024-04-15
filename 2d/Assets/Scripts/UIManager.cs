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
        UpdateCardUI();
    }
    

    // Update is called once per frame
    void Update()
    {

        
    }

    private void UpdateCardUI()
    {
        Card[] cards= CardManager.Instance.Cards;
        for (int i = 0;i<cards.Length;++i)
        {
            UpdateCardInfo(cards[i], i);
        }
    }
    private void UpdateCardInfo(Card card, int index)
    {
        if(card != null)
        {
            CardSlot cardSlot = Instantiate(_cardPrefab, _cardPanel);
            cardSlot.Index=index;
            _aviableCards.Add(cardSlot);
            Debug.Log(_aviableCards.Count);
        }
    }
    private void UpdateSelectedCard()
    {
        Debug.Log(_index);
        CardSlot selectedCard= _aviableCards[_aviableCards.Count-1].GetComponent<CardSlot>();

        CardSO card = CardManager.Instance.Cards[_index].CardData;

        Debug.Log(card.Name + " " + card.Value);
        selectedCard.Icon.sprite = card.Icon;
        selectedCard.ValueText.text = card.Value.ToString();



    }
    public void addIndex(int add)
    {
        _index += add;
        if(_index >= _aviableCards.Count ) { _index = 0; }
        else if(_index < 0) {  _index = _aviableCards.Count-1; }
        UpdateSelectedCard();
    }
}
