using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    decimal Scaledecimal   = 0.0m; 
    decimal Distansdecimal = 380.0m;

    [SerializeField] protected GlobalData globalData;

    protected decimal ScaleCount()
    {
        return Scaledecimal;
    }

    protected decimal DistansCount()
    {
        return Distansdecimal;
    }

    protected IEnumerator TimeCount()
    {
         //Timerを刻んでいます。
        for(int i = 0; i < 380; i++)
        {
            //decimalの値を代入
            Scaledecimal   += 1.0m;
            Distansdecimal -= 1.0m;

            if(globalData.GameOverFlag == true)
            {
                yield break;
            }

         yield return new WaitForSeconds(0.1f);

        }
    }

}
