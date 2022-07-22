using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class GameInterface : MainGameUI
{
    //[SerializeField] private Texture2D background;

    private VisualElement _pausePanel;
    private Button _pauseButton;
    private Button _activateShieldButton;
    private Label _timer;
    private Button _restartButton;
    private Button _resumeButton;

    private int _shieldActivationInterval = 20;

    public event Action OnPause;
    public event Action OnResume;
    public event Action OnShieldActivate;

    protected override void OnEnable()
    {
        _pausePanel = _Root.Q<VisualElement>("PauseScreen");

        _pauseButton = _Root.Q<Button>("Pause");
        _activateShieldButton = _Root.Q<Button>("ActivateShield");
        _timer = _Root.Q<Label>("Timer");
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
        // It is necessary to implement a correct pause return

        OnResume?.Invoke();
        _pausePanel.style.display = DisplayStyle.None;
    }

    private void Restart()
    {
        SceneLoader.RestartGame();

        Debug.Log("Restart");
    }

    private void ActivateShield()
    {
        //_activateShieldButton.style.backgroundImage = background;
        _activateShieldButton.SetEnabled(false);
        _timer.style.display = DisplayStyle.Flex;

        OnShieldActivate?.Invoke();

        Debug.Log("Shield Activate");

        // TO DO. Add a timer
    }

    private void Pause()
    {
        // It is necessary to implement a correct pause

        OnPause?.Invoke();
        _pausePanel.style.display = DisplayStyle.Flex;
    }


}
