using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCard : Card
{
    protected override void UseCardLogic()
    {
        //Debug.Log("Se usa ataque melee");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //en vez de hacer 1hp dmg get el ataque de player
        collision.GetComponent<IEGetDMG>()?.getDMG(1f);
    }


}
