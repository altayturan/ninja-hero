using ninjahero.events;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private GameEvent onRestart;
    [SerializeField] private Canvas statsScreen;
    public void LoadGame()
    {
        SceneLoader.Instance.LoadGame();
    }

    public void OpenStats()
    {
        statsScreen.enabled = true;
    }

    public void CloseStats()
    {
        statsScreen.enabled = false;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
