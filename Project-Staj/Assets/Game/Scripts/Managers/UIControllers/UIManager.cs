using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;

    [SerializeField] private PowerUp attackSpeedPowerUp;
    [SerializeField] private PowerUp damagePowerUp;
    [SerializeField] private PowerUp numberOfShotsPowerUp;

    

    private void Update()
    {
        //if (GameManager.Instance.gameTime > 0)
        //    timeText.text = (Mathf.FloorToInt(GameManager.Instance.gameTime / 60)).ToString("00") + ":" + (Mathf.FloorToInt(GameManager.Instance.gameTime % 60)).ToString("00");
    }
}
