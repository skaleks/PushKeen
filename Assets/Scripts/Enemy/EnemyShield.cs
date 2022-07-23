using UnityEngine;

public class EnemyShield : AbstractShield
{
    public bool IsActive()
    {
        return gameObject.activeInHierarchy ? true : false;
    }
}
