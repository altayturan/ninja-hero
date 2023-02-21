using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConditionController : MonoBehaviour
{
    public void LoseGame()
    {
        Time.timeScale = 0;
        UIManager.Instance.LoseScreen.SetActive(true);
        UIManager.Instance.Hud.SetActive(false);
    }

    public void WinGame()
    {
        Time.timeScale = 0;
        UIManager.Instance.WinScreen.SetActive(true);
        UIManager.Instance.Hud.SetActive(false);
    }
}
