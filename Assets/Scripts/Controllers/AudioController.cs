using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public void PlayMisucClick()
    {
        AudioManager.instance.PlayClickUI();
    }
}
