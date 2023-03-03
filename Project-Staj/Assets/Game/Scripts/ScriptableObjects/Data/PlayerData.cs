using ninjahero.events;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Create Player Data")]
public class PlayerData : ScriptableObject
{

    [SerializeField] private float baseSpeed;
    [SerializeField] private float baseHealth;
    [SerializeField] private int baseMaxHealth;
    [SerializeField] private float baseFireInterval;
    [SerializeField] private int baseNumberOfShots;
    [SerializeField] private float baseRange;
    [SerializeField] private int baseBulletAmount;

    [SerializeField] private Transform transform;
    [SerializeField] private GameEvent onHealthChange;

    private float speed;
    private float health;
    private int maxHealth;
    private float fireInterval;
    private int numberOfShots;
    private float range;
    private int bulletAmount;

    

    public float Speed { get { return speed; } set { speed = value; } }
    public float Health { get { return health; } set { health = value; onHealthChange.Invoke(); } }
    public int MaxHealth { get { return maxHealth; } set { maxHealth = value; } }
    public float FireInterval { get { return fireInterval; } set { fireInterval = value; } }
    public int NumberOfShots { get { return numberOfShots; } set { numberOfShots = value; } }
    public float Range { get { return range; } set { range = value; } }
    public Transform Transform { get { return transform; } set { transform = value; } }
    public int BulletAmount { get => bulletAmount; set => bulletAmount = value; }

    // Base Properties
    public void ResetPlayer()
    {
        maxHealth = baseMaxHealth;
        Health = maxHealth;
        speed = baseSpeed;
        range = baseRange;
        bulletAmount = baseBulletAmount;
        fireInterval = baseFireInterval;
        numberOfShots = baseNumberOfShots;
    }
}
