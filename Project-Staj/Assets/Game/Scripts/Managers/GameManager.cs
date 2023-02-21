using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 30;
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
        Time.timeScale = 1;
    }
}
