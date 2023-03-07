using UnityEngine;

public class DamagePowerUp : BasePowerUpButtonController
{
    [SerializeField] private BulletData bulletData;
    public override void OnClickPowerUp()
    {
        base.OnClickPowerUp();
    }

    protected override void ApplyUpgrade()
    {
        bulletData.Damage += powerUp.StatChangeAmount;
    }
}
