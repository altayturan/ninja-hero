using UnityEngine;

public class PlayerResetter : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;

    public void ResetPlayer()
    {
        playerData.Health = playerData.BaseHealth;
        playerData.Speed = playerData.BaseSpeed;
        playerData.Range = playerData.BaseRange;
        playerData.DiagonalShot = playerData.BaseDiagonalShot;
        playerData.FireInterval = playerData.BaseFireInterval;
        playerData.NumberOfShots = playerData.BaseNumberOfShots;
        playerData.Transform.position = new Vector3(0, 0, 0);
    }
}
