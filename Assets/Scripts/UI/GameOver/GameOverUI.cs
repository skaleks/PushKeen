using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class GameOverUI : MonoBehaviour
{
    private VisualElement _root;
    private VisualElement _screen;
    private Label _name;
    private Button _tryagain;
    private Button _quit;

    private void Awake()
    {
        _root = GetComponent<UIDocument>().rootVisualElement;
    }
    private void OnEnable()
    {
        _screen = _root.Q<VisualElement>("GameOverScreen");
        _name = _root.Q<Label>("Winner");
        _tryagain = _root.Q<Button>("TryAgain");
        _quit = _root.Q<Button>("Quit");

        _tryagain.clicked += TryAgain;
        _quit.clicked += Quit;
    }
    public void ShowGameOverScreen(IDamageable name)
    {
        _screen.style.display = DisplayStyle.Flex;

        _name.text = name is Player ? "You lose!" : "You win!";
    }
    private void TryAgain()
    {
        ProjectContext.Instance.SceneLoader.RestartGame();
    }
    private void Quit()
    {
        Application.Quit();
    }
}
