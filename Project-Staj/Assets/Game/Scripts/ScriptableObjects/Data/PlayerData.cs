using UnityEngine;
public enum Phases { STOPED, MOVING }

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
    [SerializeField] private Transform transform;
    [SerializeField] private Phases currentPhase;

    public float Speed { get { return speed; } set { speed = value; } }
    public float Health { get { return health; } set { health = value;} }
    public int MaxHealth { get { return maxHealth; } set { maxHealth = value; } }
    public float FireInterval { get { return fireInterval; } set { fireInterval = value; } }
    public int NumberOfShots { get { return numberOfShots; } set { numberOfShots = value; } }
    public float Range { get { return range; } set { range = value; } }

    public bool DiagonalShot { get { return diagonalShot; } set { diagonalShot = value; } }

    public Phases CurrentPhase { get { return currentPhase; } set { currentPhase = value; } }

    public Transform Transform { get { return transform; } set { transform = value; } }

    
}
