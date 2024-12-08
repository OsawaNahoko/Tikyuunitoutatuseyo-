using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundplayer : MonoBehaviour
{
    [SerializeField] AudioClip[] soundArrey;
    AudioSource audioSource;

    protected void PlaySound(int Number)
    {
        if(audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            Debug.Log("Nullでした");
        }
        audioSource.PlayOneShot(soundArrey[Number]);
    }

}
