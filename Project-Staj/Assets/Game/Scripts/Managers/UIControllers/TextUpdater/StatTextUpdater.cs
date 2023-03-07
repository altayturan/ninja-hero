using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatTextUpdater : MonoBehaviour
{
    [SerializeField] private TMP_Text totaldie;
    [SerializeField] private TMP_Text totalbullet;
    [SerializeField] private TMP_Text totalkilled;
    [SerializeField] private TMP_Text totalgold;
    [SerializeField] private TMP_Text gameplaytime;

    [SerializeField] private GameStatistics gamestats;
    public void UpdateStats()
    {
        totaldie.text = "Total Die: " + gamestats.TotalDie.ToString() + " times";
        totalbullet.text = "Total Fired Bullet: " + gamestats.TotalFiredBullet.ToString();
        totalkilled.text = "Total Killed Enemy: " + gamestats.TotalKilledEnemy.ToString();
        totalgold.text = "Total Spent Gold: " + gamestats.TotalSpentGold.ToString() + " gold";
        gameplaytime.text = "Total Gameplay Time: " + Mathf.FloorToInt(gamestats.TotalGameplayTime).ToString() + " seconds";
    }
}
