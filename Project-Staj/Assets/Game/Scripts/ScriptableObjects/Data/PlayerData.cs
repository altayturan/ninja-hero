using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Create Player Data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private Stat speed;
    [SerializeField] private Stat health;
    [SerializeField] private Stat damage;
    [SerializeField] private Stat fireInterval;
    [SerializeField] private Stat numberOfShots;
    [SerializeField] private Stat range;

    public Stat Speed { get { return speed; } }
    public Stat Health { get { return health; } }
    public Stat Damage { get { return damage; } }
    public Stat FireInterval { get { return fireInterval; } }
    public Stat NumberOfShots { get { return numberOfShots; } }
    public Stat Rang { get { return range; } }
}
