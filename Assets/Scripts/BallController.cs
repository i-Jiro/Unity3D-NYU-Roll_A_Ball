using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class BallController : MonoBehaviour
{
    public Vector3 Direction;
    
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
        _rigidbody.AddForce(Direction.normalized * _force);
    }

    void OnPlayerMove(InputValue value)
    {
        Vector2 inputVector = value.Get<Vector2>();
        Direction.x = -inputVector.x;
        Direction.y = 0;
        Direction.z = inputVector.y;
    }
}
