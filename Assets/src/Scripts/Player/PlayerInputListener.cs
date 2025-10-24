using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputListener : MonoBehaviour
{
    public Vector2 movementInputVector {  get; private set; }

    private void OnMove(InputValue inputValue)
    {
        movementInputVector = inputValue.Get<Vector2>();
    }
}
