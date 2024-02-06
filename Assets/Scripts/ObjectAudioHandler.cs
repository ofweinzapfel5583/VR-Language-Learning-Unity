using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAudioHandler : MonoBehaviour
{
    public AudioClip audioClip;

    private AudioSource audioSource;

    private void Start()
    {
        // Ensure there's an AudioSource component attached to this GameObject
        audioSource = gameObject.GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Set the AudioClip to play
        audioSource.clip = audioClip;
    }

    public void PlayAudio()
    {
        // Play the audio clip
        audioSource.Play();
    }
}
