using ninjahero.events;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skill", menuName = "Boosters/Create Skill")]
public class Skill : Booster
{
    [SerializeField] private float baseCooldown;
    [SerializeField] private GameEvent onUsed;
    [SerializeField] private float cooldown;
    [SerializeField] private GameEvent OnCooldownChanged;
    public float BaseCooldown { get { return baseCooldown;} }
    public GameEvent OnUsed { get { return onUsed; } }
    public float Cooldown { get => cooldown; set { cooldown = value; OnCooldownChanged.Invoke(); } }

    public void ResetSkill()
    {
        cost = baseCost;
        cooldown = baseCooldown;
    }
}
