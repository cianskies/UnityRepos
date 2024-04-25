using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCard : Card
{
    [SerializeField] private Fire _fireball;
    [SerializeField] private PlayerMovementController _playerPosition;

    protected override void UseCardLogic()
    {
        Fire fire=Instantiate(_fireball);
        fire.transform.position = _playerPosition.transform.position;
        fire.MovementDirection = new Vector3(_playerPosition.LastDirection.x, 0);

    }
}
