using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
[CustomEditor(typeof(PlayerData))]
public class Resetter : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Resetter"))
        {
            PlayerData myScript = (PlayerData)target;
            //myScript.Resetter();//target function. can be anything
        }
    }
}