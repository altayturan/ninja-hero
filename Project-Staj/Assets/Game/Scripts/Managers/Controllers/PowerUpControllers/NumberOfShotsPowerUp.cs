public class NumberOfShotsPowerUp : BasePowerUpButtonController
{
    public override void OnClickPowerUp()
    {
        base.OnClickPowerUp();
    }

    protected override void ApplyUpgrade()
    {
        playerData.NumberOfShots += (int)powerUp.StatChangeAmount;
    }
}
