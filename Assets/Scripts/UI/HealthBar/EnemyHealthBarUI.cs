using UnityEngine.UIElements;

public class EnemyHealthBarUI : HealthBarUI
{
    private VisualElement _healthBar;

    protected override void OnEnable()
    {
        base.OnEnable();
        _healthBar = _Root.Q<VisualElement>("EnemyHealth");
        _health = new Length();
    }
    protected override void HealthChanged(int value)
    {
        _health = value;
        _health.unit = LengthUnit.Percent;

        _healthBar.style.width = _health;
    }
}
