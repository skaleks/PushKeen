using System.Collections;
using UnityEngine;

public class Enemy : AbstractCombatant
{
    [SerializeField] private EnemyShield _shield;
    private int _intervalBetweenShieldActivation = 15;
    private int _randomDelay;
    private bool _canActivateShield = true;

    private void Update()
    {
        if (_canActivateShield)
        {
            if (!_shield.IsActive())
            {
                _randomDelay = Random.Range(1, 5);
                StartCoroutine(StartRandomShieldActivator(_randomDelay));
            }
        }
    }

    private IEnumerator StartRandomShieldActivator(int seconds)
    {
        _canActivateShield = false;

        yield return new WaitForSeconds(seconds);

        ActivateShield();
        
        yield return new WaitForSeconds(_intervalBetweenShieldActivation);
        
        _canActivateShield = true;
    }

    protected override void ActivateShield()
    {
        _shield.Activate();
    }
}
