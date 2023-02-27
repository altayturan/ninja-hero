using UnityEngine;

[CreateAssetMenu(fileName = "New Bullet Data", menuName = "Data/Create Bullet Data")]
public class BulletData : ScriptableObject
{
    [SerializeField] private float baseDamage;
    [SerializeField] private float baseSpeed;
    [SerializeField] private GameObject bulletObject;

    private float damage;
    private float speed;


    public float Speed { get { return speed; } set { speed = value; } }
    public float Damage { get { return damage; } set { damage = value; } }
    public GameObject BulletObject { get { return bulletObject; } }

    public void ResetBullet()
    {
        damage = baseDamage;
        speed = baseSpeed;
    }
}
