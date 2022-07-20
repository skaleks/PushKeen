using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerGun : MonoBehaviour
{
    private PlayerInputSystem _input;

    private void Awake()
    {
        _input = new PlayerInputSystem();
    }


    // Not working!
    // TO DO...
    public void Shoot(InputAction.CallbackContext context)
    {
        Debug.Log("Shoot " + context.phase);
    }
}
