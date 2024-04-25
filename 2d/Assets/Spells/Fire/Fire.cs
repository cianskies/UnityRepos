using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private float _SPD;
    [SerializeField] private float _ATK;
    private SpriteRenderer _spriteRenderer;
    private Vector3 _movementDirection;

    public Vector3 MovementDirection { get => _movementDirection; set => _movementDirection = value; }

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        FlipSprite();
        transform.Translate(_movementDirection*(_SPD*Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.GetComponent<IEGetDMG>()?.getDMG(1f);
        Debug.Log(collision.gameObject.name.ToString());
        if (collision.GetComponent<IEGetDMG>() != null)
        {
            collision.gameObject.GetComponent<IEGetDMG>().getDMG(2f);
            
        }
        
    }
    private void FlipSprite()
    {
        if(_movementDirection.x< 0)
        {
            _spriteRenderer.flipX = true;
        }
    }
}
