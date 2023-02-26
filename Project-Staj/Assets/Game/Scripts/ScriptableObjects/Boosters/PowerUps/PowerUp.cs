using ninjahero.events;
using UnityEngine;


[CreateAssetMenu(fileName = "New PowerUp", menuName = "Boosters/Create PowerUp")]
public class PowerUp : Booster
{
    [SerializeField] private int baseMaxLevel;
    [SerializeField] private float baseStatChangeAmount;

    private int maxLevel;
    private float statChangeAmount;

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

    public int BaseMaxLevel { get => baseMaxLevel; }
    public float BaseStatChangeAmount { get => baseStatChangeAmount; }

    public void LevelUp()
    {
        Level++;
    }

    private void OnEnable()
    {
        statChangeAmount = BaseStatChangeAmount;
        maxLevel = BaseMaxLevel;
        cost = baseCost;
        level = baseLevel;
    }
}
