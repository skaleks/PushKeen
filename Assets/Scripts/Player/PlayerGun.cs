using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerGun : AbstractGun
{
    public void Shoot(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            GameObject cannonBall = GetCannonBall();
            _cannonBallRigidBody = cannonBall.GetComponent<Rigidbody2D>();
            _cannonBallRigidBody.AddRelativeForce(Vector2.up * _shootPower, ForceMode2D.Impulse);
        }
    }
    public void MoveGun(InputAction.CallbackContext context)
    {
        while (context.performed)
        {
            var value = context.ReadValue<float>();
            Debug.Log(value);
        }
    }
}
