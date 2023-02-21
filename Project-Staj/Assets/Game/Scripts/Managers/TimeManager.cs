using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private float gameTime = 120f;
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
}
