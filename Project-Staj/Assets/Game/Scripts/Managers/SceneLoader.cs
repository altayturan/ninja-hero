using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }


    private void Start()
    {
        Application.targetFrameRate = 60;

        StartGame();
    }
    private void StartGame()
    {
        SceneManager.LoadScene(1,LoadSceneMode.Additive);
    }

    public void LoadGame()
    {
        Time.timeScale = 1;
        SceneManager.UnloadSceneAsync(1);
        SceneManager.LoadScene(2,LoadSceneMode.Additive);
        SceneManager.LoadScene(3, LoadSceneMode.Additive);
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
        SceneManager.LoadScene(3, LoadSceneMode.Additive);
    }
}
