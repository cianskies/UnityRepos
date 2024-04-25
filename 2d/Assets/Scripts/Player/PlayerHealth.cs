using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour,IEGetDMG
{
    [SerializeField] private PlayerStats _stats;


    void Start()
    {
        _stats.HP = _stats.MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.M))
        {
            getDMG(1f);
        }
    }

    public void getDMG(float DMG)
    {
        _stats.HP -= DMG;
        if (_stats.HP <= 0)
        {
            _stats.HP = 0;
            Destroy(gameObject);
        }
    }

}
