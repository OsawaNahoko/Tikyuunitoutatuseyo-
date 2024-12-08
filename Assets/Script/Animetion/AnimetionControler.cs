using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimetionControler : Soundplayer
{
    [SerializeField] Animator[]   AnimatorArray;
    [SerializeField] string[]     FlagArray;

    protected void AnimetionPlaye(int Flag)
    {
        for (int i = 0; i < AnimatorArray.Length; i++)
        {
            AnimatorArray[i].SetBool(FlagArray[Flag],true);
        }
    }

}
   
