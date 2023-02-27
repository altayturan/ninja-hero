using UnityEngine;


public enum States { PLAY, STOP }

[CreateAssetMenu(fileName = "StateData", menuName = "Data/Create State Data")]
public class StateData : ScriptableObject
{
    [SerializeField] private States currentState;

    public States CurrentState { get { return currentState; } set { currentState = value; } }
}
