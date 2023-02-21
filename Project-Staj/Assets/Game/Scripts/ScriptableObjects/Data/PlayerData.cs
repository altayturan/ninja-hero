using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Create Player Data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private float speed;
    [SerializeField] private float health;
    [SerializeField] private int maxHealth;
    [SerializeField] private float fireInterval;
    [SerializeField] private int numberOfShots;
    [SerializeField] private float range;
    [SerializeField] private bool diagonalShot = false;

    public float Speed { get { return speed; } }
    public float Health { get { return health; } set { health = value;} }
    public int MaxHealth { get { return maxHealth; } }
    public float FireInterval { get { return fireInterval; } set { fireInterval = value; } }
    public float NumberOfShots { get { return numberOfShots; } }
    public float Range { get { return range; } }

    public bool DiagonalShot { get { return diagonalShot; } }
}
