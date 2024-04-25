using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    public static event Action UseCardEvent;
    public static event Action ReloadCardsEvent;


    [SerializeField] private float _movementSpeed;
    private Vector2 _input;

    //movimiento
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
            GetActionInput();
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
        _input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        _movementDirection = _input.normalized;
        if (IsPlayerMoving())
        {
            _lastDirection = _movementDirection;
        }
    }
    private void GetActionInput() {
        if (Input.GetAxis("Jump") > 0)
        {
            Jump();
        }
        if (Input.GetAxis("Fire1") > 0&&!_isPlayerUsingCard)
        {
            StartCoroutine(IEUseCard());
        }
        if (Input.GetAxis("CardChange") != 0 && !_isPlayerChangingCard)
        {
           
            StartCoroutine(IEChangeCardSlot(Input.GetAxis("CardChange")));
        }
        if (Input.GetAxis("Reload") > 0 && !_isPlayerReloadingCard)
        {
            //Debug.Log("Ok");
            StartCoroutine(IEReloadCards());
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
        _canPlayerMove  = false;
        _isPlayerUsingCard = true;
        UseCardEvent?.Invoke();
        yield return new WaitForSeconds(0.5f);
        _isPlayerUsingCard = false;
        _canPlayerMove = true;
    }
    private IEnumerator IEChangeCardSlot(float i)
    {
        _isPlayerChangingCard=true;

        int newIndex = 0;
        if(i>0)
        {
            newIndex = 1;
        }
        else
        {
            newIndex = -1;
        }
        //Debug.Log(newIndex);
        CardManager.Instance.addIndex(newIndex);
        yield return new WaitForSeconds(0.2f);
        _isPlayerChangingCard = false;
    }
    private IEnumerator IEReloadCards()
    {
        _isPlayerReloadingCard = true;
        ReloadCardsEvent?.Invoke();
        yield return new WaitForSeconds(0.5f);
        _isPlayerReloadingCard = false;
    }


}
