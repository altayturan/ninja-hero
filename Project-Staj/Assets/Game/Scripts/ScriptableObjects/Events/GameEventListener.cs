using UnityEngine;
using UnityEngine.Events;
using ninjahero.events;
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
