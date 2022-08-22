using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class CameraController : MonoBehaviour
{
    public float DeltaX;
    public float DeltaY;
    
    [SerializeField] private GameObject _player;
    [SerializeField] private float _distanceZOffset;
    [SerializeField] private float _distanceYOffset;
    private Vector3 _offsetVector;
    private float _xRotation;
    private float _yRotation;
    public bool IsMoveToggled = false;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _offsetVector = new Vector3(0, _distanceYOffset, _distanceZOffset);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        _xRotation += DeltaX;
        _yRotation += DeltaY;
        transform.position = _player.transform.position + _offsetVector;
        if (IsMoveToggled)
            transform.rotation = Quaternion.Euler(_yRotation, _xRotation, 0);
    }
}
