using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] private GameObject _cannonBall;

    public delegate void ShootEvent();
    public event ShootEvent OnShoot;

    public void Shoot(InputAction.CallbackContext context)
    {

    }
}
