using UnityEngine;

public class PlayButtonController : MonoBehaviour
{
    public void LoadGame()
    {
        SceneLoader.Instance.LoadGame();
    }
}
