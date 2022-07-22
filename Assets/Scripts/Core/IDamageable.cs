using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable {

    int maxHealth { get; }
    int health { get; }

    event Action<int> OnHealthChanged;
}
