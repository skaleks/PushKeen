using UnityEngine;

public class EnemyHealthBar : HealthBar
{
    protected override void HealthChanged(int value)
    {
        Debug.Log("Enemy health " + value);
    }
}
