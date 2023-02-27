using ninjahero.events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private GameEvent onRestart;
    void Awake()
    {
        onRestart.Invoke();
    }
}
