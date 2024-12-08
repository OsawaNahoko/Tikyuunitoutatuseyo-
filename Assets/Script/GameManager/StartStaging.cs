using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStaging : AnimetionControler
{
    bool PlayFlag = false;
    public float WaitTime;

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
        AnimetionPlaye(0);

        yield return new WaitForSeconds(Time);

        PlaySound(1);
    }
}
