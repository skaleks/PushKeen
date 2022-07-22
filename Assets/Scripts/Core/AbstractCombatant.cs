using System;
using UnityEngine;

public abstract class AbstractCombatant : MonoBehaviour, IDamageable
{
    [SerializeField] protected int _maxHealth = 100;
    [SerializeField] protected int _health = 100;

    public event Action<int> OnHealthChanged;

    public int maxHealth => _maxHealth;
    public int health
    {
        get => _health;
        set
        {
            _health = value;
            if(_health > 0)
            {
                OnHealthChanged?.Invoke(_health);
            }
        }
    }

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        health -= 10;
    }
}
