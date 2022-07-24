using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerGun : AbstractGun
{
    [SerializeField] private float _rotationSpeed = 10f;

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.action.WasPressedThisFrame())
        {
            GameObject cannonBall = GetCannonBall();
            _cannonBallRigidBody = cannonBall.GetComponent<Rigidbody2D>();
            _cannonBallRigidBody.AddRelativeForce(Vector2.up * _shootPower, ForceMode2D.Impulse);
        }
        if (context.action.WasReleasedThisFrame())
        {

        }
    }
    public void MoveGun(InputAction.CallbackContext context)
    {
        Vector2 value = context.ReadValue<Vector2>();
        float efficiency = -value.y * _rotationSpeed * Time.deltaTime;

        _anchor.transform.Rotate(Vector3.forward * efficiency);
    }
}
