using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject userPanel;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject startPanel;

    private void OnEnable()
    {
        GameController.isGameStart += ActivateUserPanel;
        GameController.isGamePause += ActivateMenuPanel;
        GameController.isGameUnpause += ActivateUserPanel;
        GameController.isGameLose += ActivateLoseMenu;
    }

    private void OnDisable()
    {
        GameController.isGameStart -= ActivateUserPanel;
        GameController.isGamePause -= ActivateMenuPanel;
        GameController.isGameUnpause -= ActivateUserPanel;
        GameController.isGameLose -= ActivateLoseMenu;
    }
    public void ActivateUserPanel()
    {
        settingsPanel.SetActive(false);
        menuPanel.SetActive(false);
        startPanel.SetActive(false);
        userPanel.SetActive(true);
    }

    public void ActivateMenuPanel()
    {
        settingsPanel.SetActive(false);
        userPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void ActivateSettingsPanel()
    {
        menuPanel.SetActive(false);
        userPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void ActivateLoseMenu()
    {
        settingsPanel.SetActive(false);
        userPanel.SetActive(false);
        menuPanel.SetActive(false);
        losePanel.SetActive(true);
    }





}
