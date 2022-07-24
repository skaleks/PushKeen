using System;
using UnityEngine;

public abstract class AbstractCombatant : MonoBehaviour, IDamageable
{
    [SerializeField] protected int _maxHealth = 100;
    [SerializeField] protected int _health = 100;
    [SerializeField] protected int _damage = 10;
    [SerializeField] protected AbstractShield _shield;

    public event Action<int> OnHealthChanged;

    public int maxHealth => _maxHealth;
    public int health
    {
        get => _health;
        set
        {
            _health = value;
            if(_health >= 0)
            {
                OnHealthChanged?.Invoke(_health);
            }
        }
    }

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SetActive(false);
        if (!_shield.IsActive())
        {
            health -= _damage;
        }
    }
    protected abstract void ActivateShield();
}
