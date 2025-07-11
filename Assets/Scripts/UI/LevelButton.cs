using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private Image progressBar;
    [SerializeField] private Text progressText;

    public void SetProgresBar(float progress)
    {
        progressBar.fillAmount = progress/100;
        SetProgresText(progress);
    }

    public void SetProgresText(float progress)
    {
        progressText.text = progress.ToString() + "%";
    }

    public void InteractableButton(bool isUse)
    {
        var button = GetComponent<Button>();
        button.interactable = isUse;
    }
}
