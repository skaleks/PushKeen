using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class GameInterface : MainGameUI
{
    private VisualElement _pausePanel;
    private Button _pauseButton;
    private Button _activateShieldButton;
    private Label _timer;
    private Button _restartButton;
    private Button _resumeButton;

    private int _shieldActivationInterval = 15;

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
    private void Pause()
    {
        ProjectContext.Instance.PauseHandler.SetPaused(true);
        _pausePanel.style.display = DisplayStyle.Flex;
    }
    private void Resume()
    {
        ProjectContext.Instance.PauseHandler.SetPaused(false);
        _pausePanel.style.display = DisplayStyle.None;
    }
    private void Restart()
    {
        ProjectContext.Instance.SceneLoader.RestartGame();
    }
    private void ActivateShield()
    {
        StartCoroutine(RunTimer(_shieldActivationInterval));
    }
    private IEnumerator RunTimer(int seconds)
    {
        _activateShieldButton.SetEnabled(false);
        _timer.style.display = DisplayStyle.Flex;

        OnShieldActivate?.Invoke();

        while (seconds >= 0)
        {
            _timer.text = "0:" + seconds--;
            yield return new WaitForSeconds(1);
        }

        _activateShieldButton.SetEnabled(true);
        _timer.style.display = DisplayStyle.None;
    }
}
