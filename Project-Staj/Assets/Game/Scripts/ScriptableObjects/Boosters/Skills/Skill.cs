using ninjahero.events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skill", menuName = "Boosters/Create Skill")]
public class Skill : ScriptableObject
{
    [SerializeField] private int cost;
    [SerializeField] private float cooldown;
    public int Cost { get { return cost; } }
    public float Cooldown { get { return cooldown;} }
}
