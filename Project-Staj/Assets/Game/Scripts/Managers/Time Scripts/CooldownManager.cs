using UnityEngine;
using TMPro;

public class CooldownManager : MonoBehaviour
{
    [SerializeField] private SpellManager spellManager;


    private void Start()
    {
    }

    private void Update()
    {
        //if(!spellManager.damageAllCasted) { damageAllCooldowner.gameObject.SetActive(false); damageAllCooldown = spellManager.damageAllCooldownTime; }
        //else { damageAllCooldowner.gameObject.SetActive(true); damageAllCooldowner.text = Mathf.FloorToInt(damageAllCooldown).ToString(); damageAllCooldown -= Time.deltaTime; }

        //if (!spellManager.highAttackSpeedCasted) { highAttackSpeedCooldowner.gameObject.SetActive(false); highAttackSpeedCooldown = spellManager.highAttackSpeedCooldownTime + 5; }
        //else { highAttackSpeedCooldowner.gameObject.SetActive(true); highAttackSpeedCooldowner.text = Mathf.FloorToInt(highAttackSpeedCooldown).ToString(); highAttackSpeedCooldown -= Time.deltaTime; }
    }
}
