using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardSlot : MonoBehaviour
{
    private int _index;
    [SerializeField] private TextMeshProUGUI _valueText;
    [SerializeField] private Image _background;
    [SerializeField] private Image _icon;
    [SerializeField] private CardSO _info;

    public int Index {  get { return _index; } set { _index = value; } }

    public TextMeshProUGUI ValueText { get => _valueText; set => _valueText = value; }
    public Image Background { get => _background; set => _background = value; }
    public Image Icon { get => _icon; set => _icon = value; }
    public CardSO Info { get => _info; set => _info = value; }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
