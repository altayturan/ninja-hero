using ninjahero.events;
using UnityEngine;


public enum States { PLAY, STOP }

[CreateAssetMenu(fileName = "StateData", menuName = "Data/Create State Data")]
public class StateData : ScriptableObject
{
    [SerializeField] private States currentState;
    [SerializeField] private GameEvent OnPlay;
    [SerializeField] private GameEvent OnStop;

    public States CurrentState
    {
        get { return currentState; }
        set
        {
            currentState = value;
            if(currentState == States.STOP)
                OnStop.Invoke();
            else if(currentState == States.PLAY)
                OnPlay.Invoke();
        }
    }
}
