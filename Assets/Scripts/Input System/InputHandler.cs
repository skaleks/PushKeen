using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputHandler : MonoBehaviour
{
    private PlayerInput _playerInput;
    [SerializeField] private GameInterface _gameInterface;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    private void OnEnable()
    {
        _gameInterface.OnPause += DisablePlayerInput;
        _gameInterface.OnResume += EnablePlayerInput;
    }

    private void OnDisable()
    {
        _gameInterface.OnPause -= DisablePlayerInput;
        _gameInterface.OnResume -= EnablePlayerInput;
    }

    public void DisablePlayerInput()
    {
        _playerInput.DeactivateInput();
    }

    private void EnablePlayerInput()
    {
        _playerInput.ActivateInput();
    }
}
