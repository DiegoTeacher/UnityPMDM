using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public KeyCode rightKey, leftKey;
    public float speed;

    private Rigidbody2D _rb;
    private SpriteRenderer _spriteRenderer;
    private Vector2 _dir;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _dir = Vector2.zero;
        if(Input.GetKey(leftKey))
        {
            _dir = new Vector2(-1, 0);
            _spriteRenderer.flipX = false;

        }
        else if (Input.GetKey(rightKey))
        {
            _dir = new Vector2(1, 0);
            _spriteRenderer.flipX = true;
        }
    }

    private void FixedUpdate()
    {
        _rb.velocity = _dir * speed;
    }
}
