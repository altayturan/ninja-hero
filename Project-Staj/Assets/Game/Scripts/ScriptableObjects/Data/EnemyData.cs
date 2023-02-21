using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Data", menuName = "Data/Create Enemy Data")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private Stat health;
    [SerializeField] private Stat speed;
    [SerializeField] private Stat damage;
}
