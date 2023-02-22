using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BasePowerUpButtonController : MonoBehaviour
{
    [SerializeField] private Resource gold;
    [SerializeField] internal PowerUp powerUp;
    [SerializeField] internal PlayerData playerData;

    [SerializeField] private TMP_Text levelText;
    [SerializeField] private TMP_Text goldText;
    private Button powerUpButton;

    private void Start()
    {
        powerUpButton = GetComponent<Button>();
    }

    public virtual void OnClickPowerUp()
    {
        if (!gold.isEnough(powerUp.Cost)) return;
        powerUp.LevelUp();
        if (powerUp.Level + 1 > powerUp.MaxLevel) { powerUpButton.interactable = false; return; }
    }
}
