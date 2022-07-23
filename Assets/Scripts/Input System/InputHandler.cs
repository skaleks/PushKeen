using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputHandler : MonoBehaviour, IPauseable
{
    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    private void Start()
    {
        ProjectContext.Instance.PauseHandler.Add(this);
    }

    public void SetPaused(bool isPaused)
    {
        if (isPaused)
        {
            _playerInput.DeactivateInput();
        }
        else
        {
            _playerInput.ActivateInput();
        }
    }
}
