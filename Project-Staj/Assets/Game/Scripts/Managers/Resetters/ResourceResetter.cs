using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceResetter : MonoBehaviour
{
    [SerializeField] private Resource gold;
    [SerializeField] private Resource time;

    private int defaultGold;
    private int defaultTime;

    private void Awake()
    {
        defaultGold = gold.Amount;
        defaultTime = time.Amount;
    }

    public void RestartResources()
    {
        gold.Amount = defaultGold;
        time.Amount = defaultTime;
    }
}
