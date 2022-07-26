using System;
using UnityEngine;

public abstract class AbstractCombatant : MonoBehaviour, IDamageable
{
    [SerializeField] protected int _maxHealth = 100;
    [SerializeField] protected int _health = 100;
    [SerializeField] protected int _damage = 10;
    [SerializeField] protected AbstractShield _shield;
    [SerializeField] private GameOverHandler gameoverHandler;

    public event Action<int> OnHealthChanged;

    public int MaxHealth => _maxHealth;
    public int Health
    {
        get => _health;
        set
        {
            _health = value;

            OnHealthChanged?.Invoke(_health);

            if (_health <= 0)
            {
                gameoverHandler.GameOver(this);
            }
        }
    }

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SetActive(false);

        if (!_shield.IsActive())
        {
            if(Health > 0)
            {
                Health -= _damage;
            }
        }
    }
    protected abstract void ActivateShield();
}
