using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerGun : AbstractGun
{
    [SerializeField] private float _rotationSpeed;
    private bool _canShoot = true;
    private Coroutine _coroutine;

    public void Shoot(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            _canShoot = true;
            _coroutine = StartCoroutine(Shooting());
        }
        if (context.canceled)
        {
            _canShoot = false;
            if(_coroutine != null)
            {
                StopCoroutine(_coroutine);
                _coroutine = null;
            }
        }
    }
    public void MoveGun(InputAction.CallbackContext context)
    {
        Vector2 value = context.ReadValue<Vector2>();
        float efficiency = -value.y * _rotationSpeed * Time.deltaTime;

        _anchor.transform.Rotate(Vector3.forward * efficiency);
    }

    private IEnumerator Shooting()
    {
        while (_canShoot)
        {
            GameObject cannonBall = GetCannonBall();
            _cannonBallRigidBody = cannonBall.GetComponent<Rigidbody2D>();
            _cannonBallRigidBody.AddRelativeForce(Vector2.up * _shootPower, ForceMode2D.Impulse);

            yield return new WaitForSeconds(0.5f);
        }
    }
}
