using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource _audioSource;
    [SerializeField] private AudioClip[] _audioClip;

    void Start()
    {
        _audioSource.PlayOneShot(_audioClip[Random.Range(0, _audioClip.Length)]);
    }
}
