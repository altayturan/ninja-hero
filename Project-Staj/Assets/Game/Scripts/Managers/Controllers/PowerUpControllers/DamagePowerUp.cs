using UnityEngine;

public class DamagePowerUp : BasePowerUpButtonController
{
    [SerializeField] private BulletData bulletData;
    public override void OnClickPowerUp()
    {
        base.OnClickPowerUp();
        bulletData.Damage += powerUp.StatChangeAmount;
    }
}
