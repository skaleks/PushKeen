using UnityEngine;

public class PlayerHealthBar : HealthBar
{
    protected override void HealthChanged(int value)
    {
        Debug.Log("Player health " + value);
    }
}
