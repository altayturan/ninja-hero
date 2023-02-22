using ninjahero.events;
using UnityEngine;


public class PlayerEventFunctions : MonoBehaviour
{

    [SerializeField] private GameEvent OnLoseGameEvent;
    public void OnPlayerDie()
    {
        OnLoseGameEvent.Invoke();
    }
}
