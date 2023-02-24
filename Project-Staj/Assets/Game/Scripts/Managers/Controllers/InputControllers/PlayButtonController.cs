using ninjahero.events;
using UnityEngine;

public class PlayButtonController : MonoBehaviour
{
    [SerializeField] private GameEvent onRestart;
    public void LoadGame()
    {
        SceneLoader.Instance.LoadGame();
    }
}
