using ninjahero.events;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private GameEvent onRestart;
    [SerializeField] private StateData stateData;
    void Awake()
    {
        stateData.CurrentState = States.PLAY;
        onRestart.Invoke();
    }
}
