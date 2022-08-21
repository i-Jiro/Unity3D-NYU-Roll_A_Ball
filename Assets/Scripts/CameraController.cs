using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _distanceZOffset;
    [SerializeField] private float _distanceYOffset;
    private Vector3 _offsetVector;

    // Start is called before the first frame update
    void Start()
    {
        _offsetVector = new Vector3(0, _distanceYOffset, _distanceZOffset);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _player.transform.position + _offsetVector;
    }
}
