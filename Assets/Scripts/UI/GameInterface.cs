using System;
using UnityEngine;
using UnityEngine.UIElements;


[RequireComponent(typeof(UIDocument))]
public class GameInterface : MonoBehaviour
{
    protected VisualElement _root;
    private VisualElement _pausePanel;

    private void Awake()
    {
        _root = GetComponent<UIDocument>().rootVisualElement;
        
    }

    private void OnEnable()
    {
        _pausePanel = _root.Q<VisualElement>("PauseScreen");

        Button pauseButton = _root.Q<Button>("Pause");
        Button activateShieldButton = _root.Q<Button>("ActivateShield");
        Button restartButton = _pausePanel.Q<Button>("Restart");
        Button resumeButton = _pausePanel.Q<Button>("Resume");

        pauseButton.clicked += Pause;
        activateShieldButton.clicked += ActivateShield;
        restartButton.clicked += Restart;
        resumeButton.clicked += Resume;
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
