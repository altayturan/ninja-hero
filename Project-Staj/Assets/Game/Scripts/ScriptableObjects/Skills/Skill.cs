using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skill", menuName = "Create Skill")]
public class Skill : ScriptableObject
{
    private int cost;
    private float cooldown;
    [SerializeField] private PlayerData playerData;

    
}
