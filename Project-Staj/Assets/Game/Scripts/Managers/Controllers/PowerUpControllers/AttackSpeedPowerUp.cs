public class AttackSpeedPowerUp : BasePowerUpButtonController
{
    public override void OnClickPowerUp()
    {
        base.OnClickPowerUp();
    }

    protected override void ApplyUpgrade()
    {
        playerData.FireInterval -= powerUp.StatChangeAmount;

    }
}
