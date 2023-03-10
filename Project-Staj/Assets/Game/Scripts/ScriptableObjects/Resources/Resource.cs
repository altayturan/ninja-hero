using ninjahero.events;
using UnityEngine;

[CreateAssetMenu(fileName = "New Resource", menuName = "Create Resource")]
public class Resource : ScriptableObject
{
    [SerializeField] private int baseAmount;

    [SerializeField] private GameEvent onResourceChange;

    private int amount;
    public int Amount
    {
        get { return amount; }
        set
        {
            amount = value;
            onResourceChange.Invoke();
        }
    }
    public bool isEnough(int val)
    {
        if (Amount >= val)
        {
            Amount -= val;
            return true;
        }
        return false;
    }

    public void ResetResources()
    {
        Amount = baseAmount;
    }

}
