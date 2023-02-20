using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Cost", menuName = "Create Cost")]
public class Cost : ScriptableObject
{
    [SerializeField] private int amount;

    public int Amount
    {
        get { return amount; }
        set
        {
            amount = value;

        }
    }
}
