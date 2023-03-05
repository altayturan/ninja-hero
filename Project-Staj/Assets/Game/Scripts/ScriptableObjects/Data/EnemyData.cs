using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Data", menuName = "Data/Create Enemy Data")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private float baseHealth;
    [SerializeField] private float baseSpeed;
    [SerializeField] private float baseDamage;
    [SerializeField] private int basePrize;

    private float health;
    private float speed;
    private float damage;
    private int prize;
    public float Health { get { return health; } set { health = value; } }
    public float Speed { get { return speed; } set { speed = value; } }
    public float Damage { get { return damage; } set { damage = value; } }

    public int Prize { get { return prize; } set { prize = value; } }


    public void RestartEnemy()
    {
        health = baseHealth;
        speed = baseSpeed;
        damage = baseDamage;
        prize = basePrize;
    }
}   
