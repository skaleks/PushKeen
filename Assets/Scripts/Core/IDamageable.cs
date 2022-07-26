using System;
public interface IDamageable {

    int MaxHealth { get; }
    int Health { get; }
    event Action<int> OnHealthChanged;
}
