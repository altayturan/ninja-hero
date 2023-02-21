using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bullet Data",menuName ="Data/Create Bullet Data")]
public class BulletData : ScriptableObject
{
    [SerializeField] private Stat damage;
    [SerializeField] private Stat speed;
    [SerializeField] private GameObject bulletObject;


    public Stat Speed { get { return damage; } }
    public Stat Damage { get { return damage; } }
    public GameObject BulletObject { get { return bulletObject; } }
}
