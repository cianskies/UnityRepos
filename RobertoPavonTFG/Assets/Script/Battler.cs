using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Battler : MonoBehaviour
{

    [SerializeField] protected string _name;
    [SerializeField] protected float _hpValue;
    [SerializeField] protected float _maxHpValue;

    [SerializeField] protected bool _hostile;

    [SerializeField] protected string _action;

    public string Action { get { return _action; }set { _action = value; } }
    public bool Hostile { get { return _hostile; }set { _hostile = value; } }



    void Start()
    {
        SuscribeToBattleManager();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SuscribeToBattleManager()
    {
        BattleManager.Instance.AddBattlerToManager(this);
        Debug.Log("Añadido a battle Manager");
    }
    protected abstract void OnChangedNewTurnStarted();
}
