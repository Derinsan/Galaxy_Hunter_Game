using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundControl : MonoBehaviour
{
    public AudioMixerGroup Mixer;
    BackgroundMusic backgroundMusic;

    public void ToggleMusic(bool enabled)
    {
        if (enabled)
        {
            Mixer.audioMixer.SetFloat("MusicVolume", 0);
        }
        else
        {
            Mixer.audioMixer.SetFloat("MusicVolume", -80);
        }

        PlayerPrefs.SetInt("MusicEnabled", enabled ? 1 : 0);
        // backgroundMusic._audioSource.Play();
    }
}
