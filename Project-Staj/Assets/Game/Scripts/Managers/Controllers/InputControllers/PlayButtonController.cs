using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonController : MonoBehaviour
{
    public void LoadGame()
    {
        SceneLoader.Instance.LoadGame();
    }
}
