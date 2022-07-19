using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerGun : MonoBehaviour
{
    private PlayerInput _input;

    private void Awake()
    {
        _input = new PlayerInput();
    }


    // Not working!
    // TO DO...
    public void Shoot(InputAction.CallbackContext context)
    {
        Debug.Log("Shoot");
    }
}
