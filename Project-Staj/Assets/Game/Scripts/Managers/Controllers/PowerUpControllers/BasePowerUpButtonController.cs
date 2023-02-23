using ninjahero.events;
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
    [SerializeField] private Button powerUpButton;
    [SerializeField] private GameEvent OnGoldChange;

    public virtual void OnClickPowerUp()
    {
        if (!gold.isEnough(powerUp.Cost)) return;
        powerUp.LevelUp();
        OnGoldChange.Invoke();
        if (powerUp.Level + 1 > powerUp.MaxLevel) { powerUpButton.interactable = false; return; }
    }
}
