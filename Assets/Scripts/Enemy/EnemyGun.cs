using System.Collections;
using UnityEngine;

public class EnemyGun : AbstractGun
{
    private void Start()
    {
        StartCoroutine(nameof(Shoot));
    }

    private IEnumerator Shoot()
    {
        yield return new WaitForSeconds(3);

        GameObject cannonBall = GetCannonBall();
        _cannonBallRigidBody = cannonBall.GetComponent<Rigidbody2D>();
        _cannonBallRigidBody.AddRelativeForce(Vector2.right * _shootPower, ForceMode2D.Impulse);
    }
}
