using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CroissantSound : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (!audioSource)
        {
            Debug.LogError("AudioSource component not found on croissant GameObject.");
        }
        else
        {
            // Assign the AudioClip programmatically
            audioSource.clip = Resources.Load<AudioClip>("dasCroissant");
        }
    }

    public void PlayPickupSound()
    {
        if (audioSource && audioSource.clip)
        {
            audioSource.Play();
        }
    }
}
