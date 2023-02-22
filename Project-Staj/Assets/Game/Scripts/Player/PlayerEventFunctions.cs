using ninjahero.events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerEventFunctions : MonoBehaviour
{

    [SerializeField] private GameEvent OnLoseGameEvent;
    public void OnPlayerDie()
    {
        OnLoseGameEvent.Invoke();
    }
}
