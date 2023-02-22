using UnityEngine;
using ninjahero.events;
public class TimeEventFunctions : MonoBehaviour
{
    [SerializeField] private GameEvent OnWinGameEvent;

    public void OnTimeEnd()
    {
        OnWinGameEvent.Invoke();
    }
}
