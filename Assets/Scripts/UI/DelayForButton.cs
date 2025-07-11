using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayForButton : MonoBehaviour
{
    private float secDelay;
    private Button buttonComp;

    private void Awake()
    {
        buttonComp = GetComponent<Button>();
    }
    public void SetDelay(float sec)
    {
        secDelay = sec;
        SetInteractableButton(false);
    }

    private void Update()
    {
        if (secDelay < 0)
        {
            SetInteractableButton(true);
        }
        else
        {
            secDelay -= Time.deltaTime;
        }
    }

    private void SetInteractableButton(bool isTrue)
    {
        buttonComp.interactable = isTrue;
    }
}
