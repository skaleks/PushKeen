using System;
using UnityEngine;

public class Player : AbstractCombatant
{
    [SerializeField] private GameInterface _gameInterface;
    [SerializeField] private GameObject _shield;

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
        _shield.SetActive(true);
    }
}
