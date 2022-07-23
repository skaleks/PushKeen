using UnityEngine;

public class Player : AbstractCombatant
{
    [SerializeField] private GameInterface _gameInterface;

    private void OnEnable()
    {
        _gameInterface.OnShieldActivate += ActivateShield;
    }
    private void OnDisable()
    {
        _gameInterface.OnShieldActivate -= ActivateShield;
    }
    protected override void ActivateShield()
    {
        _shield.Activate();
    }
}
