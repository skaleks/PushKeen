using UnityEngine;

public class PlayerShield : AbstractShield
{
    private const string ENEMYBALL = "EnemyBall";
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(ENEMYBALL))
        {
            base.OnTriggerEnter2D(collision);
        }
    }
}
