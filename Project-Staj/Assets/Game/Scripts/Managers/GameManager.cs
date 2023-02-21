using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Singleton
    private GameManager gameManager;
    private static GameManager _instance;

    public static GameManager Instance { get { return _instance; } }

    private void Awake()
    {

        if (_instance != null && _instance != this)  // SINGLETON
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        gameManager = new GameManager();
    }
    #endregion

    #region Variables

    public bool isPlayerAlive = true;
    public float gameTime = 120f;
    public List<EnemyController> enemyControllers;

    #endregion

    #region Monobehaviour Functions
    private void Start()
    {
        Application.targetFrameRate = 30;
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
        InvokeRepeating("ReduceTime", 1f, 1f);
        
        Time.timeScale = 1;
    }
    private void Update()
    {
        CheckForEnding();
    }
    #endregion

    #region Functions

    private void CheckForEnding()
    {
        if (isPlayerAlive == false) LoseGame();
        if (gameTime <= 0 && isPlayerAlive == true) WinGame();
    }

    private void LoseGame()
    {
        Time.timeScale = 0;
        UIManager.Instance.LoseScreen.SetActive(true);
        UIManager.Instance.Hud.SetActive(false);
    }

    private void WinGame()
    {
        Time.timeScale = 0;  
        UIManager.Instance.WinScreen.SetActive(true);
        UIManager.Instance.Hud.SetActive(false);
    }

    private void ReduceTime()
    {
        gameTime--;
    }
    
    #endregion
}
