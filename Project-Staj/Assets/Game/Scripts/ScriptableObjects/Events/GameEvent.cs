using System.Collections.Generic;
using UnityEngine;

namespace ninjahero.events
{

    [CreateAssetMenu(fileName = "New Game Event", menuName = "Game Event", order = 52)]
    public class GameEvent : ScriptableObject
    {
        private List<GameEventListener> listeners = new List<GameEventListener>();

        public void Invoke()
        {
            Debug.LogWarning($"{name} Invoked");
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised();
            }
        }

        public void SubscribeListener(GameEventListener listener)
        {
            listeners.Add(listener);
        }

        public void UnsubscribeListener(GameEventListener listener)
        {
            listeners.Remove(listener);
        }
    }
}

