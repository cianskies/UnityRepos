using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class PlayerMovementController : MonoBehaviour
{

    public static event Action<int> UseCardEvent;
    public static event Action<int> ReloadCardsEvent;


    [SerializeField] private float _movementSpeed;
    private Vector2 _input;

    [SerializeField] private int _playerNum;
    //movimiento
    private PlayerControls _playerControls;
    [SerializeField] private Vector2 _movementDirection;
    [SerializeField] private Vector2 _lastDirection;

    //ataque

    

    private Rigidbody2D _rb2d;

    private bool _canPlayerMove = true;
    private bool _isPlayerJumping;
    private bool _isPlayerUsingCard=false;
    private bool _isPlayerChangingCard=false;
    private bool _isPlayerReloadingCard=false;
    public bool IsPlayerMoving()
    {
        return _movementDirection != Vector2.zero;
    }
    public bool IsplayerJumping()
    {
        return _isPlayerJumping;
    }
    public Vector2 MovementDirection { get => _movementDirection; set => _movementDirection = value; }
    public Vector2 LastDirection { get => _lastDirection; set => _lastDirection = value; }

    private void Awake()
    {
        _playerControls = new PlayerControls();
    }
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _lastDirection = Vector2.right;
    }

    // Update is called once per frame
    void Update()
    {
        if (_canPlayerMove)
        {
            GetMovementInput();
        }

    }
    private void FixedUpdate()
    {
        if (_canPlayerMove)
        {
            _rb2d.MovePosition(_rb2d.position + _movementDirection * _movementSpeed * Time.fixedDeltaTime);
        }

    }


    private void GetMovementInput()
    {
        if(_playerNum==1) {
            _input = _playerControls.Player1Map.Movement.ReadValue<Vector2>();
        }
        else
        {
            _input = _playerControls.Player2Map.Movement.ReadValue<Vector2>();
        }

        _movementDirection = _input.normalized;
        if (IsPlayerMoving())
        {
            _lastDirection = _movementDirection;
        }
    }

    
    public bool GetPlayerHorizontalDirection()
    {
        bool derecha = false;

        if (IsPlayerMoving() && _lastDirection.x < 0)
        {
            derecha = true;
        }
        return derecha;
    }
    private void Jump()
    {
        //_isPlayerJumping = true;
        //simular logica de salto
    }

    private IEnumerator IEUseCard()
    {
        if(!_isPlayerUsingCard) {
            _canPlayerMove = false;
            _isPlayerUsingCard = true;
            UseCardEvent?.Invoke(_playerNum);
            yield return new WaitForSeconds(0.5f);
            _isPlayerUsingCard = false;
            _canPlayerMove = true;
        }

    }
    private IEnumerator IEChangeCardSlot(float i)
    {
        if (!_isPlayerChangingCard)
        {
            _isPlayerChangingCard = true;

            int newIndex = 0;
            if (i > 0)
            {
                newIndex = 1;
            }
            else
            {
                newIndex = -1;
            }
            //Debug.Log(newIndex);




            CardManager.Instance.addIndex(newIndex, CardManager.Instance.Cards(_playerNum));
            yield return new WaitForSeconds(0.2f);
            _isPlayerChangingCard = false;
        }
        
    }
    private IEnumerator IEReloadCards()
    {
        if (!_isPlayerReloadingCard)
        {
            _isPlayerReloadingCard = true;
            ReloadCardsEvent?.Invoke(_playerNum);
            yield return new WaitForSeconds(0.5f);
            _isPlayerReloadingCard = false;
        }
    }

    private void OnEnable()
    {
        _playerControls.Enable();

        if (_playerNum == 1)
        {
            _playerControls.Player1Map.ChangeCards.performed += ctx => StartCoroutine(IEChangeCardSlot(_playerControls.Player1Map.ChangeCards.ReadValue<float>()));
            _playerControls.Player1Map.UseCard.performed += ctx => StartCoroutine(IEUseCard());
            _playerControls.Player1Map.Reload.performed += ctx => StartCoroutine(IEReloadCards());
        }
        else
        {
            _playerControls.Player2Map.ChangeCards.performed += ctx => StartCoroutine(IEChangeCardSlot(_playerControls.Player1Map.ChangeCards.ReadValue<float>()));
            _playerControls.Player2Map.UseCard.performed += ctx => StartCoroutine(IEUseCard());
            _playerControls.Player2Map.Reload.performed += ctx => StartCoroutine(IEReloadCards());
        }

    }
    private void OnDisable()
    {
        _playerControls.Disable();
    }
}
