using ninjahero.events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New PowerUp", menuName = "Create PowerUp")]
public class PowerUp : ScriptableObject
{
    [SerializeField] private int cost;
    [SerializeField] private int level;
    [SerializeField] private int maxLevel;
    [SerializeField] private float statChangeAmount;

    [SerializeField] private GameEvent OnLevelChanged;
    public int Cost
    {
        get { return cost; }
        set
        {
            cost = value;
        }
    }
    public int Level
    {
        get { return level; }
        set
        {
            level = value;
            OnLevelChanged.Invoke();
        }
    }

    public int MaxLevel
    {
        get { return maxLevel; }
        set
        {
            maxLevel = value;
        }
    }
    public float StatChangeAmount
    {
        get { return statChangeAmount; }
        set
        {
            statChangeAmount = value;
        }
    }
    public void LevelUp()
    {
        Level++;
    }
}
