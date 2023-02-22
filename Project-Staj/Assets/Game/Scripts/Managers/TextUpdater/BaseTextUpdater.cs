using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BaseTextUpdater : MonoBehaviour
{
    private TMP_Text targetText;

    private void Awake()
    {
        targetText = GetComponent<TMP_Text>();    
    }

    public void SetText(string value)
    {
        targetText.text = value;
    }
}
