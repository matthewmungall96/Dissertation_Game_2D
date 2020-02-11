﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSettings : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetMusicVolume(float musicVolume)
    {
        audioMixer.SetFloat("musicVolume", musicVolume);
        AudioVariables.musicVolume = musicVolume;
    }

    public void SetSFXVolume(float sfxVolume)
    {
        audioMixer.SetFloat("sfxVolume", sfxVolume);
        AudioVariables.sfxVolume = sfxVolume;
    }
}
