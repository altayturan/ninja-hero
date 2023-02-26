using ninjahero.events;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skill", menuName = "Boosters/Create Skill")]
public class Skill : Booster
{
    [SerializeField] private float cooldown;
    [SerializeField] private GameEvent onUsed;
    public float Cooldown { get { return cooldown;} }

    public GameEvent OnUsed { get { return onUsed; } }  
}
