using UnityEngine;

public abstract class AbstractShield : MonoBehaviour
{
    [SerializeField] protected int _shieldHealth;
    protected int counter;

    public void Activate()
    {
        gameObject.SetActive(true);
        counter = _shieldHealth;
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
        counter = _shieldHealth;
    }

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        counter--;

        if (counter <= 0)
        {
            Deactivate();
        }
    }
}
