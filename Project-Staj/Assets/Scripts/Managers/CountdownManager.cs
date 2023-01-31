using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownManager : MonoBehaviour
{
    [SerializeField] private TMP_Text damageAllCountdowner;
    [SerializeField] private TMP_Text highAttackSpeedCountdowner;

    [SerializeField] private SpellManager spellManager;

    private float damageAllCountdown;
    private float highAttackSpeedCountdown;

    private void Start()
    {
    }

    private void Update()
    {
        if(!spellManager.damageAllCasted) { damageAllCountdowner.gameObject.SetActive(false); damageAllCountdown = spellManager.damageAllCountdownTime; }
        else { damageAllCountdowner.gameObject.SetActive(true); damageAllCountdowner.text = Mathf.FloorToInt(damageAllCountdown).ToString(); damageAllCountdown -= Time.deltaTime; }

        if (!spellManager.highAttackSpeedCasted) { highAttackSpeedCountdowner.gameObject.SetActive(false); highAttackSpeedCountdown = spellManager.HighAttackSpeedCountdownTime + 5; }
        else { highAttackSpeedCountdowner.gameObject.SetActive(true); highAttackSpeedCountdowner.text = Mathf.FloorToInt(highAttackSpeedCountdown).ToString(); highAttackSpeedCountdown -= Time.deltaTime; }
    }
}
