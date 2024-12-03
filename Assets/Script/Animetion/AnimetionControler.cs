using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimetionControler : MonoBehaviour
{
    [SerializeField] Animator[]   AnimatorArray;
    protected void AnimetionPlaye()
    {
        for (int i = 0; i < AnimatorArray.Length; i++)
        {
            AnimatorArray[i].SetBool("GameOverFlag",true);
        }
    }
}
   
