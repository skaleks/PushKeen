using UnityEngine;

public class EnemyShield : AbstractShield
{
    private const string PLAYERBALL = "PlayerBall";
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(PLAYERBALL))
        {
            base.OnTriggerEnter2D(collision);
        }
    }
}
