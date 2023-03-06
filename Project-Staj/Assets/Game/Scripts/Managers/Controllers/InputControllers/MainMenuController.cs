using ninjahero.events;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private GameEvent onRestart;
    public void LoadGame()
    {
        SceneLoader.Instance.LoadGame();
    }

    public void OpenSettings()
    {

    }

    public void CloseSettings()
    {
    }

    public void Quit()
    {
        Application.Quit();
    }
}
