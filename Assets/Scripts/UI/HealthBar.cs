using System;
using UnityEngine;

public abstract class HealthBar : MainGameUI
{
    protected IDamageable _damageable;
    [SerializeField] protected GameObject _character;

    private void Awake()
    {
        _damageable = _character.GetComponent<IDamageable>();
    }

    protected override void OnEnable()
    {
        _damageable.OnHealthChanged += HealthChanged;
    }
    protected override void OnDisable()
    {
        _damageable.OnHealthChanged -= HealthChanged;
    }

    protected abstract void HealthChanged(int value);
}
