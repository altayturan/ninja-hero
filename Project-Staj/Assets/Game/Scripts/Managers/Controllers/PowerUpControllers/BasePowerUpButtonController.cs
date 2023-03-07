using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class BasePowerUpButtonController : MonoBehaviour
{
    [SerializeField] private Resource gold;
    [SerializeField] protected PowerUp powerUp;
    [SerializeField] protected PlayerData playerData;
    [SerializeField] protected GameStatistics gameStatistics;

    [SerializeField] private TMP_Text levelText;
    [SerializeField] private TMP_Text goldText;
    [SerializeField] private Button powerUpButton;

    private void OnEnable()
    {
        powerUpButton.onClick.AddListener(OnClickPowerUp);
    }
    private void OnDisable()
    {
        powerUpButton.onClick.RemoveListener(OnClickPowerUp);
    }

    public virtual void OnClickPowerUp()
    {
        if (!gold.isEnough(powerUp.Cost)) return;
        ApplyUpgrade();
        gameStatistics.TotalSpentGold += powerUp.Cost;
        powerUp.LevelUp();
        if (powerUp.Level + 1 > powerUp.MaxLevel) { powerUpButton.interactable = false; return; }
    }
    protected abstract void ApplyUpgrade();
}
