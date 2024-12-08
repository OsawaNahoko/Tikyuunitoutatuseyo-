using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimetionControler : Soundplayer
{
    [SerializeField] Animator[]   AnimatorArray;
    protected void GameOverAnimetionPlaye()
    {
        for (int i = 0; i < AnimatorArray.Length; i++)
        {
            AnimatorArray[i].SetBool("GameOverFlag",true);
        }
    }

    protected void GameClearAnimetionPlaye()
    {
        for (int i = 0; i < AnimatorArray.Length; i++)
        {
            AnimatorArray[i].SetBool("GameClearFlag",true);
        }
    }
}
   
