using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpResetter : MonoBehaviour
{
    [SerializeField] private PowerUp powerUp;

    private int defaultCost;
    private int defaultLevel;
    private float defaultStatChangeAmount;
    void Awake()
    {
        defaultCost = powerUp.Cost;
        defaultLevel = powerUp.Level;
        defaultStatChangeAmount = powerUp.StatChangeAmount;
    }

    public void ResetPowerUp()
    {
        powerUp.Cost = defaultCost;
        powerUp.Level = defaultLevel;
        powerUp.StatChangeAmount = defaultStatChangeAmount;
    }
}
