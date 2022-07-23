using System.Collections;
using UnityEngine;

public class EnemyGun : AbstractGun
{
    [SerializeField] private GameObject _player;
    [SerializeField] private PlayerShield _playerShield;

    private void Start()
    {
        StartCoroutine(nameof(Shoot));
    }

    private void Update()
    {
        if (_playerShield.IsActive())
        {
            MoveGunDown();
        }
        else
        {
            MoveGunUp();
        }
    }


    private IEnumerator Shoot()
    {
        yield return new WaitForSeconds(2);

        GameObject cannonBall = GetCannonBall();
        _cannonBallRigidBody = cannonBall.GetComponent<Rigidbody2D>();
        _cannonBallRigidBody.AddRelativeForce(Vector2.up * _shootPower, ForceMode2D.Impulse);
    }

    private void MoveGunDown()
    {
        _anchor.transform.rotation = Quaternion.Euler(0, 0, -30);
    }
    private void MoveGunUp()
    {
        _anchor.transform.rotation = Quaternion.Euler(0, 0, 0);
    }


}
