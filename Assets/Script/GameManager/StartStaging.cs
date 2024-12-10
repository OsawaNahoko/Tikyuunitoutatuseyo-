using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStaging : Soundplayer
{
    bool PlayFlag = false;
    public float WaitTime;

    void Start()
    {
        PlayTriggerAnime(0);
    }

    public void SEPlay()
    {
        if(PlayFlag == false)
        {
            PlayFlag = true;
            StartCoroutine(Staging(WaitTime));
        }
        else if(PlayFlag == true)
        {
            return;
        }
    }

    IEnumerator Staging(float Time)
    {
        PlaySound(0);
        PlayBoolAnime(0);

        yield return new WaitForSeconds(Time);

        PlaySound(1);
        PlayBoolAnime(1);
    }
}
