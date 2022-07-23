using UnityEngine;

public class ProjectContext : MonoBehaviour
{
    public PauseHandler PauseHandler { get; private set; }
    public SceneLoader SceneLoader { get; private set; }

    public static ProjectContext Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        PauseHandler = new PauseHandler();
        SceneLoader = new SceneLoader();
    }
}
