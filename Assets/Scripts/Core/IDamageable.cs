using System;
public interface IDamageable {

    int maxHealth { get; }
    int health { get; }
    event Action<int> OnHealthChanged;
}
