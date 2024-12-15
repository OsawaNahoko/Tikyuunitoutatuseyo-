using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]protected GlobalData globalData;
    decimal earthScaledecimal   = 0.0m;
    decimal earthDistansdecimal = 0.0m;
    [SerializeField]float DistansFloat;

    protected decimal earthScale()
    {
        return earthScaledecimal;
    }

    protected decimal earthDistans()
    {
        return earthDistansdecimal;
    }

    protected float Distansfloat()
    {
        return DistansFloat;
    }

    protected IEnumerator EarthCount()
    {
        earthDistansdecimal = (decimal)DistansFloat;

         //Timerを刻んでいます。
        for(float i = 0.0f; i < DistansFloat; i++)
        {
            //計算しています。
            earthScaledecimal   += 0.01m;
            earthDistansdecimal -= 1.0m;

            if(globalData.GameOverFlag == true)
            {
                yield break;
            }

         yield return new WaitForSeconds(0.1f);

        }
    }

}
