using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TridimensionalMovement : MonoBehaviour
{
    public float speed, jumpForce;
    private Rigidbody _rb;
    private Vector3 _nVel;
    private bool _intentionToJump;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        _nVel = new Vector3(x * speed, _rb.velocity.y, z * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            _intentionToJump = true;    
        }
    }

    private void FixedUpdate()
    {
        _rb.velocity = _nVel;

        if(_intentionToJump)
        {
            _rb.AddForce(Vector3.up * jumpForce * Physics.gravity.magnitude, ForceMode.Impulse);
            _intentionToJump = false;
        }
    }
}
