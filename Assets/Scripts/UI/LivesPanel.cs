using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesPanel : MonoBehaviour
{
    [SerializeField] private Image imageLives;

    private void OnEnable()
    {
        PlayerLives.isLivesChanged += ShowLivesPanel;
    }

    private void OnDisable()
    {
        PlayerLives.isLivesChanged -= ShowLivesPanel;
    }
    private void ShowLivesPanel(float lives)
    {
        imageLives.fillAmount = lives/100;
    }
}
