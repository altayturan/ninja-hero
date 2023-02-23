using UnityEngine;
using UnityEngine.UI;

public class HealthSliderUpdater : MonoBehaviour
{
    private Slider healthBar;
    [SerializeField] private PlayerData playerData;


    private void Awake()
    {
        healthBar = GetComponent<Slider>(); 
    }
    public void UpdateHealthBar()
    {
        healthBar.maxValue = playerData.MaxHealth;
        healthBar.value = playerData.Health;
    }
}
