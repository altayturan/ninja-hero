using UnityEngine;
using ninjahero.events;
using System.Collections;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private Resource time;

    [SerializeField] private GameEvent OnTimeEndEvent;
    [SerializeField] private GameEvent OnTimeReducedInSeconds;
    [SerializeField] private StateData stateData;

    private void Start()
    {
        StartCoroutine(ReduceTimeInSeconds());

    }
    private void CheckForTimeEnd()
    {
        if (time.Amount <= 0)
        {
            OnTimeEndEvent.Invoke();
        }
    }
    private IEnumerator ReduceTimeInSeconds()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            OnTimeReducedInSeconds.Invoke();
            if (stateData.CurrentState == States.PLAY)
            {
                time.Amount--;
                CheckForTimeEnd();
            }
        }
    }

    [ContextMenu("Set Time 5 Seconds")]
    private void SetTime5Seconds()
    {
        time.Amount = 5;
    }
}
