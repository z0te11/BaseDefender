using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class AudioManager : MonoBehaviour
{
    public AudioSource musicMenu;
    public AudioSource musicGame;
    public AudioSource musicClickUI;
    public AudioMixerGroup Mixer;
    public float masterVolumeFloat;
    public float musicVolumeFloat;
    public float effectsVolumeFloat;
    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        { 
	        instance = this; 
	    } else if (instance != this)
        { 
	        Destroy(gameObject);
	    }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        ChangeVolume(0.9f);
        ChangeVolumeMusic(0.9f);
        ChangeVolumeEffects(0.9f);
    }

    public void ChangeVolume(float volume)
    {
        masterVolumeFloat = volume;
        Mixer.audioMixer.SetFloat("MasterVolume", Mathf.Lerp(-80, 0, volume));
    }

    public void ChangeVolumeEffects(float effectsvolume)
    {
        effectsVolumeFloat = effectsvolume;
        Mixer.audioMixer.SetFloat("EffectsVolume", Mathf.Lerp(-80, 0, effectsvolume));
    }

    public void ChangeVolumeMusic(float musicvolume)
    {
        musicVolumeFloat = musicvolume;
        Mixer.audioMixer.SetFloat("MusicVolume", Mathf.Lerp(-80, 0, musicvolume));
    }

    public void PlayGameMusic()
    {
        musicGame.Play();
        musicMenu.Stop();
    }

    public void PlayMenuMusic()
    {
        musicMenu.Play();
        musicGame.Stop();
    }

    public void PlayClickUI()
    {
        musicClickUI.Play();
    }

}
