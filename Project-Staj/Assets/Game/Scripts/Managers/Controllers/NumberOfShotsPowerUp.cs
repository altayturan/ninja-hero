using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberOfShotsPowerUp : BasePowerUpButtonController
{

    public override void OnClickPowerUp()
    {
        base.OnClickPowerUp();
        playerData.NumberOfShots += (int) powerUp.StatChangeAmount;
    }

}
