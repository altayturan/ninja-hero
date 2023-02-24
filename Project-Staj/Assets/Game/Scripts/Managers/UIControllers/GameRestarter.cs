using ninjahero.events;
using UnityEngine;

public class GameRestarter : MonoBehaviour
{
    [SerializeField] private GameObject LoseScreen;
    [SerializeField] private GameObject WinScreen;
    [SerializeField] private GameObject Hud;

    [SerializeField] private GameEvent OnRestart;

    public void TriggerRestart()
    {
        OnRestart.Invoke();

        Time.timeScale = 1;
        WinScreen.SetActive(false);
        LoseScreen.SetActive(false);
        Hud.SetActive(true);
    }
}
