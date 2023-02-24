using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActivator : MonoBehaviour
{
    [SerializeField] private Button button;
    public void EnableButton()
    {
        button.interactable = true;
    }
}
