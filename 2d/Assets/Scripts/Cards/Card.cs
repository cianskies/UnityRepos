using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName =("CardDB/Attack"))]
public abstract class Card : MonoBehaviour
{
    [SerializeField]private CardSO _cardSO;
    private int _value;


    public CardSO CardData { get => _cardSO; set => _cardSO = value; }
    public int Value { get => _value; set => _value = value; }

    public void UseCard()
    {
        UseCardLogic();
    }
    protected virtual void UseCardLogic() { }
}
