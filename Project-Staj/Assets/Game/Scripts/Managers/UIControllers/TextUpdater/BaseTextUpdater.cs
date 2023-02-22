using TMPro;
using UnityEngine;

public abstract class BaseTextUpdater : MonoBehaviour
{
    private TMP_Text targetText;

    private void Awake()
    {
        targetText = GetComponent<TMP_Text>();
    }
    private void Start()
    {
        SetText();
    }

    public void SetText()
    {
        targetText.text = GetText();
    }

    protected abstract string GetText();
}
