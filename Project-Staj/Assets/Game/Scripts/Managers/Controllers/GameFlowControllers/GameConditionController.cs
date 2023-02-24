using UnityEngine;

public class GameConditionController : MonoBehaviour
{
    [SerializeField] private Canvas LoseScreen;
    [SerializeField] private Canvas WinScreen;
    [SerializeField] private Canvas Hud;
    public void LoseGame()
    {
        Time.timeScale = 0;
        LoseScreen.enabled = true;
        Hud.enabled = false;
    }

    public void WinGame()
    {
        Time.timeScale = 0;
        WinScreen.enabled = true;
        Hud.enabled = false;
    }
}
