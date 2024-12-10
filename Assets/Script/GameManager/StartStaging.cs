using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStaging : SEplayer
{
    bool PlayFlag = false;
    [SerializeField]float WaitTime;
    [SerializeField]GameObject earthDistansObj;


    void Awake()
    {
        PlayFadeIN();
        GameManager.GameSeneFlag = false;
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

        yield return new WaitForSeconds(1.0f);
        
        earthDistansObj.SetActive(true);
    }
}
