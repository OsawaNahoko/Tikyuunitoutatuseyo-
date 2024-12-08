using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class earth_Distans : Base_planet
{
    [SerializeField] Text earthDistansText;
    decimal Distansdecimal = 100.0m;

    protected IEnumerator earthDistansCount(int Time,float Speed)
    {
        for(int i = 0; i < Time; i++)
        {
        
        Distansdecimal -= 0.1m;
        float Distansfloat =(float)Distansdecimal;

        earthDistansText.text  = $"{Distansfloat:F2}Km";

        yield return new WaitForSeconds(Speed);

        if(globalData.GameOverFlag == true)
        {
            yield break;
        }
        }
    }
}
