using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldManager : MonoBehaviour
{
    #region Singleton
    private GoldManager goldManager;
    private static GoldManager _instance;

    public static GoldManager Instance { get { return _instance; } }

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
        goldManager = new GoldManager();
    }
    #endregion

    #region Variables
    [SerializeField] private int gold = 0;
    #endregion



    #region Functions
    public int GetGold() { return gold; }
    public void ChangeGoldWithAmount(int amount) { gold += amount; }
    #endregion
}
