using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    decimal Scaledecimal;
    decimal Distansdecimal;

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
        // Scaledecimal  =(decimal)Timer;
        // Distansdecimal=(decimal)Timer;

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

         yield return new WaitForSeconds(1.0f);

        }
    }

}
