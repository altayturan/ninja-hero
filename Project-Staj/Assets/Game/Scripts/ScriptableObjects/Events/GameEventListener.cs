using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField]
    private GameEvent gameEvent; 
    [SerializeField]
    private UnityEvent response; 

    private void OnEnable() 
    {
        gameEvent.SubscribeListener(this);
    }

    private void OnDisable() 
    {
        gameEvent.UnsubscribeListener(this);
    }

    public void OnEventRaised() 
    {
        response.Invoke();
    }
}
