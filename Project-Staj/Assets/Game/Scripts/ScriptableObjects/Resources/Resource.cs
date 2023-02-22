using UnityEngine;

[CreateAssetMenu(fileName = "New Resource", menuName = "Create Resource")]
public class Resource : ScriptableObject
{
    [SerializeField] private int amount;
    public int Amount
    {
        get { return amount; }
        set
        { amount = value; }
    }

    public bool isEnough(int val)
    {
        if(amount >= val)
        {
            amount -= val;
            return true;
        }
        

        return false;
    }

}
