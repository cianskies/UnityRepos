using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowDMGText : MonoBehaviour
{
    private ShowDMGText _DMGTextDelegate;
    private TextMeshProUGUI _dmgText;
    void Start()
    {
        _dmgText = GetComponent<TextMeshProUGUI>();
    }

    private void ShowDMGTextUI()
    {

    }

    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        
    }
}
