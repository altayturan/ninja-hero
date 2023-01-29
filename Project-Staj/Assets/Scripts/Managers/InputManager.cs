using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Singleton
    private InputManager inputManager;
    private static InputManager _instance;

    public static InputManager Instance { get { return _instance; } }

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
        inputManager = new InputManager();
    }
    #endregion


    private Vector3 originPosition;
    private Vector3 currentPosition;

    private void Update()
    {

        if (Input.touchCount > 0 && (Input.touches[0].phase != TouchPhase.Moved || Input.touches[0].phase == TouchPhase.Stationary))
        {
            originPosition = Camera.main.ScreenToWorldPoint(Input.touches[0].rawPosition);
            currentPosition = Camera.main.ScreenToWorldPoint(Input.touches[0].position);

            Debug.Log("OriginPosition: " + originPosition);
            Debug.Log("CurrentPosition: " + currentPosition);
        }
        else
        {
            currentPosition= Vector3.zero; originPosition= Vector3.zero;
        }

    }

    public Vector3 GetDirectionNormalized()
    {
        Vector3 modifiedCurrent = new Vector3(currentPosition.x, 0, currentPosition.z);
        Vector3 modifiedOrigin = new Vector3(originPosition.x, 0, originPosition.z);


        return (modifiedCurrent - modifiedOrigin).normalized;
    }
}

