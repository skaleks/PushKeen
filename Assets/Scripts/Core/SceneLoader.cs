using UnityEngine.SceneManagement;

public class SceneLoader
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }
}
