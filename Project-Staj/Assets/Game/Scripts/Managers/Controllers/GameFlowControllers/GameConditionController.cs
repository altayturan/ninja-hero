using ninjahero.events;
using UnityEngine;

public class GameConditionController : MonoBehaviour
{
    [SerializeField] private Canvas LoseScreen;
    [SerializeField] private Canvas WinScreen;
    [SerializeField] private Canvas Hud;

    [SerializeField] private GameEvent OnRestart;
    [SerializeField] private GameEvent OnStop;
    [SerializeField] private GameEvent OnPlay;
    [SerializeField] private StateData stateData;
    public void LoseGame()
    {
        OnStop.Invoke();
        stateData.CurrentState = States.STOP;
        LoseScreen.enabled = true;
        Hud.enabled = false;
        
    }

    public void WinGame()
    {
        OnStop.Invoke();
        stateData.CurrentState = States.STOP;
        WinScreen.enabled = true;
        Hud.enabled = false;
        
    }

    public void RestartGame()
    {
        OnRestart.Invoke();
        WinScreen.enabled = false;
        LoseScreen.enabled = false;
        Hud.enabled = true;
    }
}
