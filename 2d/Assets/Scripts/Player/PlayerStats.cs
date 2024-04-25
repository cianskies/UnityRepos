using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Stats")]
public class PlayerStats : ScriptableObject
{
    [Header("HP")]
    public float HP;
    public float MaxHP;

    [Header("MP")]
    public float MP;
    public float MaxMP;

    [Header("ATK")]
    public float ATK;
    public float ATKBOOST;

    [Header("SPD")]
    public float SPD;
    public float SPDBOOST;


}
