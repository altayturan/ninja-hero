using ninjahero.events;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skill", menuName = "Boosters/Create Skill")]
public class Skill : ScriptableObject
{
    [SerializeField] private int cost;
    [SerializeField] private float cooldown;
    [SerializeField] private GameEvent onUsed;
    public int Cost { get { return cost; } }
    public float Cooldown { get { return cooldown;} }

    public GameEvent OnUsed { get { return onUsed; } }  
}
