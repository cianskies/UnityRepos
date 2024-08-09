using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : Singleton<BattleManager>
{
    public bool IsPlayerTurn;
    public Battler SelectedPlayer;

    [SerializeField]public List<Battler> Battlers=new();

    private void Start()
    {
        SelectedPlayer=GetNextPlayer();
    }
    public void AddBattlerToManager(Battler battler)
    {
        Battlers.Add(battler);
        
    }
    private Battler GetNextPlayer()
    {
        Battler nextPlayer = null;
        for (int i = 0; i < Battlers.Count; i++)
        {
            Battler b = Battlers[i];

            if (!b.Hostile && b.Action != null)
            {
                nextPlayer = b;
            }
        }
        return nextPlayer;
    }
}
