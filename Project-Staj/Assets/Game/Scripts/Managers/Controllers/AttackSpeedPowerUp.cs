using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpeedPowerUp : BasePowerUpButtonController
{
    public override void OnClickPowerUp()
    {
        base.OnClickPowerUp();
        playerData.FireInterval -= powerUp.StatChangeAmount;
    }
}
