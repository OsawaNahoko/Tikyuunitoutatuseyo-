using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundplayer : AnimetionControler
{
    [SerializeField] AudioClip[] soundArrey;
    [SerializeField] AudioSource audioSource;

    protected void PlaySound(int Number)
    {
        if(audioSource == null)
        {
            Debug.Log("audioSourceがnullです。");
        }
        else
        {
            audioSource.PlayOneShot(soundArrey[Number]);
        }
    }
        

}
