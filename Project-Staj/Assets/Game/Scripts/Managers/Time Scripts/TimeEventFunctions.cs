using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeEventFunctions : MonoBehaviour
{
    [SerializeField] private GameEvent OnWinGameEvent;

    public void OnTimeEnd()
    {
        OnWinGameEvent.Invoke();
    }
}
