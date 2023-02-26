using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpResetter : MonoBehaviour
{
    [SerializeField] private PowerUp powerUp;


    public void ResetPowerUp()
    {
        powerUp.Cost = powerUp.BaseCost;
        powerUp.Level = powerUp.BaseLevel;
        powerUp.StatChangeAmount = powerUp.BaseStatChangeAmount;
    }
}
