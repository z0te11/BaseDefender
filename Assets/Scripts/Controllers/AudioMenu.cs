using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMenu : AudioController
{
    private void Start()
    {
        AudioManager.instance.PlayMenuMusic();
    }
}
