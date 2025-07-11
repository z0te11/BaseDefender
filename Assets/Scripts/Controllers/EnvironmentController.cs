using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{
    [SerializeField] private GameObject planetObject;
    [SerializeField] private Material mainSkyBox;
    [SerializeField] private Material secondSkyBox;
    [SerializeField] private Material thirdSkyBox;
    private void Awake()
    {
        SetSkyBox(DataBase.numberPhase);
    }

    private void SetSkyBox(int numberPhase)
    {
        if (numberPhase == 0)
        {
            RenderSettings.skybox = mainSkyBox;
            if (planetObject != null) planetObject.SetActive(true);
        }
        if (numberPhase == 1)
        {
            RenderSettings.skybox = secondSkyBox;
            if (planetObject != null) planetObject.SetActive(false);
        }
        if (numberPhase == 2)
        {
            RenderSettings.skybox = thirdSkyBox;
            if (planetObject != null) planetObject.SetActive(false);
        }
    }
}
