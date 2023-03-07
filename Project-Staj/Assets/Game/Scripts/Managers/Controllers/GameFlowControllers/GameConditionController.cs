using ninjahero.events;
using UnityEngine;

public class GameConditionController : MonoBehaviour
{
    [SerializeField] private Canvas LoseScreen;
    [SerializeField] private Canvas WinScreen;
    [SerializeField] private Canvas PauseScreen;
    [SerializeField] private Canvas Hud;

    [SerializeField] private GameEvent OnRestart;
    [SerializeField] private StateData stateData;
    public void LoseGame()
    {
        stateData.CurrentState = States.STOP;
        LoseScreen.enabled = true;
        Hud.enabled = false;

    }

    public void WinGame()
    {
        stateData.CurrentState = States.STOP;
        WinScreen.enabled = true;
        Hud.enabled = false;

    }
    public void PauseGame()
    {
        stateData.CurrentState = States.PAUSE;
        PauseScreen.enabled = true;
    }
    public void UnPauseGame()
    {
        stateData.CurrentState = States.PLAY;
        PauseScreen.enabled = false;
    }

    public void RestartGame()
    {
        OnRestart.Invoke();
        WinScreen.enabled = false;
        LoseScreen.enabled = false;
        Hud.enabled = true;
    }
}
