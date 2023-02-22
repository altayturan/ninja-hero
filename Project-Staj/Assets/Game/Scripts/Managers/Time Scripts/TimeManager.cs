using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ninjahero.events;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private float gameTime = 120f;
    public float GameTime { get { return gameTime; } }

    [SerializeField] private GameEvent OnTimeEndEvent;

    private void Start()
    {
        InvokeRepeating("ReduceTime", 1f, 1f);
    }
    private void ReduceTime()
    {
        gameTime--;
        if(gameTime <= 0)
        {
            OnTimeEndEvent.Invoke();
        }
    }

    [ContextMenu("Set Time 5 Seconds")]
    private void SetTime5Seconds()
    {
        gameTime = 5f;
    }
}
