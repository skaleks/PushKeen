using UnityEngine;

public class ProjectContext : MonoBehaviour
{
    public static ProjectContext Instance { get; private set; }

    public PauseHandler PauseHandler { get; private set; }
    public SceneLoader SceneLoader { get; private set; }

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
