using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Singleton
    private PlayerController playerController;
    private static PlayerController _instance;

    public static PlayerController Instance { get { return _instance; } }

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
        playerController = new PlayerController();
    }
    #endregion

    #region Variables
    public float health;
    public float speed;
    public GameObject bulletObject;

    public float fireInterval = 2f;
    public int numberOfShots = 1;
    public bool diagonalShot = false;
    #endregion

    #region Monobehavior Functions
    private void Start()
    {
        StartCoroutine(FireBullet());
    }
    #endregion


    #region Functions

    private IEnumerator FireBullet()
    {
        for (int i = 0; i < numberOfShots; i++)
        {
            if (!diagonalShot) { Instantiate(bulletObject, transform.position, Quaternion.identity); }
            else { Instantiate(bulletObject, transform.position, Quaternion.Euler(0,-30,0));
                Instantiate(bulletObject, transform.position, Quaternion.Euler(0, 30, 0));
                Instantiate(bulletObject, transform.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(0.3f);
        }
        yield return new WaitForSeconds(fireInterval);
        yield return FireBullet();
    }

    
    #endregion
}
