using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType
{
    Attack,
    Magic,
    Item
}
[CreateAssetMenu(menuName ="Cards/Card")]
public class CardSO:ScriptableObject
{
    public CardType CardType;
    public string Name;
    public string Family;
    public string Description;
    public int Value;
    public int CPCost;
    public Sprite Icon;
}
