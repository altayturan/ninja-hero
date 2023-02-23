using UnityEngine;

public class GameConditionController : MonoBehaviour
{
    [SerializeField] private GameObject LoseScreen;
    [SerializeField] private GameObject WinScreen;
    [SerializeField] private GameObject Hud;
    public void LoseGame()
    {
        Time.timeScale = 0;
        LoseScreen.SetActive(true);
        Hud.SetActive(false);
    }

    public void WinGame()
    {
        Time.timeScale = 0;
        WinScreen.SetActive(true);
        Hud.SetActive(false);
    }

    public void RestartGame()
    {
        SceneLoader.Instance.RestartGame();
    }
}
