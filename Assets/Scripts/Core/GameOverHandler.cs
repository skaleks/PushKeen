using UnityEngine;

public class GameOverHandler : MonoBehaviour
{
    [SerializeField] private GameOverUI _gameOverUI;

    public void GameOver(IDamageable loser)
    {
        _gameOverUI.ShowGameOverScreen(loser);
        ProjectContext.Instance.PauseHandler.SetPaused(true);
    }
}
