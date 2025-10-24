using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Serialized Fields
    [SerializeField]private float characterSpeed = 3.0f;

    //Non-Serialized Fields
    private PlayerInputListener _playerInputListener;
    private Rigidbody2D _rigidbody;
    private Vector2 _movement;

    private void Awake()
    {
        _playerInputListener = GetComponent<PlayerInputListener>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _movement.x = _playerInputListener.movementInputVector.x;
        _movement.y = _playerInputListener.movementInputVector.y;
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _movement * characterSpeed * Time.fixedDeltaTime);
    }

}
