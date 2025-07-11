using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private Slider masterSlider;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider effectsSlider;
    private void OnEnable()
    {
        masterSlider.value = AudioManager.instance.masterVolumeFloat;
        musicSlider.value = AudioManager.instance.musicVolumeFloat;
        effectsSlider.value = AudioManager.instance.effectsVolumeFloat;
    }
    public void ChangeVolume(float volume)
    {
        AudioManager.instance.ChangeVolume(volume);
    }

    public void ChangeVolumeEffects(float effectsvolume)
    {
        AudioManager.instance.ChangeVolumeEffects(effectsvolume);
    }

    public void ChangeVolumeMusic(float musicvolume)
    {
        AudioManager.instance.ChangeVolumeMusic(musicvolume);
    }
}
