public class NumberOfShotsPowerUp : BasePowerUpButtonController
{
    public override void OnClickPowerUp()
    {
        base.OnClickPowerUp();
        playerData.NumberOfShots += (int) powerUp.StatChangeAmount;
    }

}
