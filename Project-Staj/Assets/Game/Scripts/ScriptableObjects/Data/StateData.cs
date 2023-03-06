using ninjahero.events;
using UnityEngine;


public enum States { PLAY, STOP, PAUSE }

[CreateAssetMenu(fileName = "StateData", menuName = "Data/Create State Data")]
public class StateData : ScriptableObject
{
    [SerializeField] private States currentState;
    [SerializeField] private GameEvent OnPlay;
    [SerializeField] private GameEvent OnStop;
    [SerializeField] private GameEvent OnPause;

    public States CurrentState
    {
        get { return currentState; }
        set
        {
            currentState = value;
            if (currentState == States.STOP)
                OnStop.Invoke();
            else if (currentState == States.PLAY)
                OnPlay.Invoke();
            else if (currentState == States.PAUSE)
                OnPause.Invoke();
        }
    }
}
