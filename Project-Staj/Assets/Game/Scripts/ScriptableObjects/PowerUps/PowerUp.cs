using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Cost", menuName = "Create Cost")]
public class PowerUp : ScriptableObject
{
    [SerializeField] private int cost;
    [SerializeField] private int level;
    [SerializeField] private int maxLevel;

    [SerializeField] private GameEvent OnLevelChanged;
    [SerializeField] private Stat stat;
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
    }

    public void LevelUp()
    {
        Level++;
        stat.Amount -= 0.1f;
    }
}
