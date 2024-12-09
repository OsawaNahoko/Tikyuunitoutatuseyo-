using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimetionControler : Soundplayer
{
    [SerializeField] Animator[]   AnimatorArray;
    [SerializeField] string[]     FlagArray;

    protected void PlayAnimetion(int FlagCount)
    {
        for (int i = 0; i < AnimatorArray.Length; i++)
        {
            AnimatorArray[i].SetBool(FlagArray[FlagCount],true);
        }
    }

}
   
