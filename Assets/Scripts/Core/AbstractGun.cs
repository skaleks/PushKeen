using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractGun : MonoBehaviour
{
    [SerializeField] private GameObject _cannonBall;
    [SerializeField] protected float _shootPower;
    [SerializeField] protected GameObject _anchor;
    [SerializeField] protected GameObject _dulo;

    protected List<GameObject> _cannonBallPool;
    protected int _poolLength = 10;
    protected Rigidbody2D _cannonBallRigidBody;

    private void Awake()
    {
        _cannonBallPool = new List<GameObject>();

        GameObject prefab;

        for (int i = 0; i < _poolLength; i++)
        {
            prefab = Instantiate(_cannonBall);
            prefab.SetActive(false);
            _cannonBallPool.Add(prefab);
        }
    }

    protected GameObject GetCannonBall()
    {
        foreach(GameObject prefab in _cannonBallPool)
        {
            if (!prefab.activeInHierarchy)
            {
                SetCannonBallPosition(prefab);
                return prefab;
            }
        }
        return null;
    }

    private void SetCannonBallPosition(GameObject prefab)
    {
        prefab.transform.position = _dulo.transform.position;
        prefab.transform.rotation = _dulo.transform.localRotation;
        prefab.SetActive(true);
    }
}
