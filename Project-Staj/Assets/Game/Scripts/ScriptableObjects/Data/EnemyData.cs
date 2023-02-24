using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Data", menuName = "Data/Create Enemy Data")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private float health;
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    [SerializeField] private int prize;

    public float Health { get { return health; } set { health = value; }  }
    public float Speed { get { return speed; } set { speed = value; } }
    public float Damage { get { return damage;} }

    public int Prize { get { return prize; } set { prize = value; } }
}
