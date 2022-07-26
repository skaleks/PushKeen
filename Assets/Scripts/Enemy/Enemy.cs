using System.Collections;
using UnityEngine;

public class Enemy : AbstractCombatant, IPauseable
{
    private int _intervalBetweenShieldActivation = 15;
    private int _randomDelay;
    private bool _canActivateShield = true;
    private bool _isPaused = false;
    private Coroutine _shieldActivator;

    private void Start()
    {
        ProjectContext.Instance.PauseHandler.Add(this);
    }
    private void Update()
    {
        if (_canActivateShield && !_isPaused)
        {
            if (!_shield.IsActive())
            {
                _randomDelay = Random.Range(1, 5);
                _shieldActivator = StartCoroutine(StartRandomShieldActivator(_randomDelay));
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
    public void SetPaused(bool value)
    {
        _isPaused = value;
        _canActivateShield = !value;

        if (_isPaused)
        {
            StopCoroutine(_shieldActivator);
        }
    }
}
