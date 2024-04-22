using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{

    private PlayerMovementController _playerMovementController;
    private Animator _animator;
    private SpriteRenderer _sprite;

    private readonly int _movement = Animator.StringToHash("Walk");
    private readonly int _meleeAttack = Animator.StringToHash("MeleeAttack");
    private readonly int _magicAttack = Animator.StringToHash("MagicAttack");
    private readonly int _jump = Animator.StringToHash("Jump");


    void Start()
    {
        _animator = GetComponent<Animator>();
        _playerMovementController = GetComponent<PlayerMovementController>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        UpdatePlayerMovement();
        FlipPlayerSprite();
        UpdatePlayerJump();

    }

    private void UpdatePlayerMovement()
    {
        _animator.SetBool(_movement, _playerMovementController.IsPlayerMoving());
    }
    private void FlipPlayerSprite()
    {
        if (_playerMovementController.IsPlayerMoving())
        {
            _sprite.flipX = _playerMovementController.GetPlayerHorizontalDirection();
        }
    }
    private void UpdatePlayerJump()
    {
        _animator.SetBool(_jump, _playerMovementController.IsplayerJumping());
    }

    public void UseCardPerformedAnim(CardSO cardData)
    {
        switch(cardData.CardType)
        {
            case(CardType.Attack):
                _animator.SetTrigger(_meleeAttack);
                break;
            case (CardType.Magic):
                _animator.SetTrigger(_magicAttack);
                break;
        }
    }


}
