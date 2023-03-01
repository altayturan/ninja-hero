using UnityEngine;
using ninjahero.events;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private Resource time;

    [SerializeField] private GameEvent OnTimeEndEvent;
    [SerializeField] private GameEvent OnTimeReduced;
    [SerializeField] private StateData stateData; 
    private void Start()
    {
        InvokeRepeating("ReduceTime", 1f, 1f);
    }
    private void ReduceTime()
    {
        if (stateData.CurrentState != States.PLAY) return;
        time.Amount--;
        OnTimeReduced.Invoke();
        if(time.Amount <= 0)
        {
            OnTimeEndEvent.Invoke();
        }
    }

    [ContextMenu("Set Time 5 Seconds")]
    private void SetTime5Seconds()
    {
        time.Amount = 5;
    }
}
