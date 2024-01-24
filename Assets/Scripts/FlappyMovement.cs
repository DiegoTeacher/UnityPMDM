using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyMovement : MonoBehaviour
{
    public float force;
    public KeyCode jumpKey;

    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN 
        // pc
        if(Input.GetKeyDown(jumpKey))
        {
            _rb.velocity = Vector3.zero;
            _rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
#elif UNITY_ANDROID
        // movil
        foreach(Touch toque in Input.touches)
        {
            if (toque.phase == TouchPhase.Began)
            {
                _rb.velocity = Vector3.zero;
                _rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            }
        }
#endif
    }
}
