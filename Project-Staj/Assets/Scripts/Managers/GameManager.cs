using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    [SerializeField] private float gameTime = 60f;

    #endregion

    #region Monobehaviour Functions
    private void Start()
    {
        Time.timeScale = 1;
    }
    private void Update()
    {
        gameTime -= Time.deltaTime;
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
        Time.timeScale = 0;  // UI ÇIKACAK
    }

    private void WinGame()
    {
        Time.timeScale = 0;  // UI ÇIKACAK
    }
    #endregion
}
