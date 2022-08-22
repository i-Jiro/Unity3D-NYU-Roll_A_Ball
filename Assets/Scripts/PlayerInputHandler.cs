using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] private CameraController _playerCamera;
    [SerializeField] private BallController _playerBall;
    
    
    void OnPlayerMove(InputValue value)
    {
        Vector2 inputVector = value.Get<Vector2>();
        _playerBall.Direction.x = -inputVector.x;
        _playerBall.Direction.y = 0;
        _playerBall.Direction.z = inputVector.y;
    }
    
    // On holding the right mouse button , enable a flag to allow rotating the camera. On release, disable flag.
    void OnToggleCameraMove()
    {
        _playerCamera.IsMoveToggled = !_playerCamera.IsMoveToggled;
    }

    void OnCameraMove(InputValue value)
    {
        if (!_playerCamera.IsMoveToggled) return;
        Vector2 InputVector = value.Get<Vector2>();
        _playerCamera.DeltaX = InputVector.x;
        _playerCamera.DeltaY = InputVector.y;
    }
    
}
