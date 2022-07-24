using UnityEngine;

public class CannonBall : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        if (gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }
    }
}
