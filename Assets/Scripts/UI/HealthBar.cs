using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public abstract class HealthBar : MonoBehaviour
{
    protected VisualElement _Root;
    protected IDamageable _damageable;
    protected Length _health;
    [SerializeField] protected GameObject _character;

    private void Awake()
    {
        _Root = GetComponent<UIDocument>().rootVisualElement;
        _damageable = _character.GetComponent<IDamageable>();
    }

    protected virtual void OnEnable()
    {
        if (_damageable != null)
        {
            _damageable.OnHealthChanged += HealthChanged;
        }
    }
    protected virtual void OnDisable()
    {
        if (_damageable != null)
        {
            _damageable.OnHealthChanged -= HealthChanged;
        }
    }
    protected abstract void HealthChanged(int value);
}
