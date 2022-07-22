using UnityEngine.SceneManagement;

public static class SceneLoader
{
    public static void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }
}
