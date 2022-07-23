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
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);

        counter--;

        if (counter <= 0)
        {
            Deactivate();
        }
    }

    public bool IsActive()
    {
        return gameObject.activeInHierarchy ? true : false;
    }
}
