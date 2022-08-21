using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallController : MonoBehaviour
{
    private Vector3 _direction;
    private Rigidbody _rigidbody;
    [SerializeField] private float _force;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.AddForce(_direction.normalized * _force);
    }

    void OnPlayerMove(InputValue value)
    {
        Vector2 inputVector = value.Get<Vector2>();
        _direction.x = -inputVector.x;
        _direction.y = 0;
        _direction.z = inputVector.y;
    }
}
