using System;
using UnityEngine;
using UnityEngine.UIElements;



public class GameInterface : MainGameUI
{
    private VisualElement _pausePanel;
    private Button _pauseButton;
    private Button _activateShieldButton;
    private Button _restartButton;
    private Button _resumeButton;


    protected override void OnEnable()
    {
        _pausePanel = _Root.Q<VisualElement>("PauseScreen");

        _pauseButton = _Root.Q<Button>("Pause");
        _activateShieldButton = _Root.Q<Button>("ActivateShield");
        _restartButton = _pausePanel.Q<Button>("Restart");
        _resumeButton = _pausePanel.Q<Button>("Resume");

        _pauseButton.clicked += Pause;
        _activateShieldButton.clicked += ActivateShield;
        _restartButton.clicked += Restart;
        _resumeButton.clicked += Resume;
    }
    protected override void OnDisable()
    {
        _pauseButton.clicked -= Pause;
        _activateShieldButton.clicked -= ActivateShield;
        _restartButton.clicked -= Restart;
        _resumeButton.clicked -= Resume;
    }

    private void Resume()
    {
        Debug.Log("Resume");

        _pausePanel.style.display = DisplayStyle.None;
    }

    private void Restart()
    {
        Debug.Log("Restart");

        // TO DO
    }

    private void ActivateShield()
    {
        Debug.Log("Shield Activate");

        // TO DO
    }

    private void Pause()
    {
        Debug.Log("Pause");

        _pausePanel.style.display = DisplayStyle.Flex;

        // TO DO
    }


}
