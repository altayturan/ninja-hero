using ninjahero.events;
using UnityEngine;

public class GameRestarter : MonoBehaviour
{
    [SerializeField] private Canvas LoseScreen;
    [SerializeField] private Canvas WinScreen;
    [SerializeField] private Canvas Hud;

    [SerializeField] private GameEvent OnRestart;

    public void TriggerRestart()
    {
        OnRestart.Invoke();

        Time.timeScale = 1;
        WinScreen.enabled= false;
        LoseScreen.enabled = false;
        Hud.enabled = true;
    }
}
