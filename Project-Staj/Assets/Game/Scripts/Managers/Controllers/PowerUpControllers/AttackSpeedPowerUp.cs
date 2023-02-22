public class AttackSpeedPowerUp : BasePowerUpButtonController
{
    public override void OnClickPowerUp()
    {
        base.OnClickPowerUp();
        playerData.FireInterval -= powerUp.StatChangeAmount;
    }
}
