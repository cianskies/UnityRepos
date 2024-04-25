using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : MonoBehaviour, IEGetDMG
{
    [SerializeField] private float _HP;
    [SerializeField] private float _MaxHP;
    private ShowDMGText _showDMGTextEvent;

    public void getDMG(float DMG)
    {
        _showDMGTextEvent.nam;
        _HP -= DMG;
        if (_HP <= 0)
        {
            Destroy(gameObject);
            //Implementar logica de dropeo de objetos etc
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _HP=_MaxHP;
    }

}
