using ninjahero.events;
using UnityEngine;


[CreateAssetMenu(fileName = "New PowerUp", menuName = "Boosters/Create PowerUp")]
public class PowerUp : Booster
{
    [SerializeField] private int maxLevel;
    [SerializeField] private float statChangeAmount;

    [SerializeField] private GameEvent OnLevelChanged;
    public override int Level
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
