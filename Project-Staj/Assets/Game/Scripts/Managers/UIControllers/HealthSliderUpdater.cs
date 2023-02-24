using UnityEngine;
using UnityEngine.UI;

public class HealthSliderUpdater : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private PlayerData playerData;

    public void UpdateHealthBar()
    {
        healthBar.maxValue = playerData.MaxHealth;
        healthBar.value = playerData.Health;
    }
}
