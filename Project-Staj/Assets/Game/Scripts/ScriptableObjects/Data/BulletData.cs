using UnityEngine;

[CreateAssetMenu(fileName = "New Bullet Data", menuName = "Data/Create Bullet Data")]
public class BulletData : ScriptableObject
{
    [SerializeField] private float baseDamage;
    [SerializeField] private float baseSpeed;

    private float damage;
    private float speed;

    [SerializeField] private GameObject bulletObject;


    private void OnEnable()
    {
        damage = BaseDamage; 
        speed = BaseSpeed;
    }

    public float Speed { get { return speed; } set { speed = value; } }
    public float Damage { get { return damage; } set { damage = value; } }
    public GameObject BulletObject { get { return bulletObject; } }

    public float BaseDamage { get => baseDamage; }
    public float BaseSpeed { get => baseSpeed; }
}
