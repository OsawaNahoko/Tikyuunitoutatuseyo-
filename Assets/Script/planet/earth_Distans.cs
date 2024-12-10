using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class earth_Distans : Base_planet
{
    [SerializeField] Text earthDistansText;
    decimal Distansdecimal = 380.0m;

    protected IEnumerator earthDistansCount(int Time,float Speed)
    {
        for(int i = 0; i < Time; i++)
        {    
            Distansdecimal -= 0.1m;
            float Distansfloat =(float)Distansdecimal;

        if(Distansfloat <= 0.0f)
        {
            Debug.Log("処理通っているよ");
            earthDistansText.text  = $"{0.0f:F2}Km";
            yield break; // ループを終了
        }
        earthDistansText.text  = $"{Distansfloat:F2}Km";
        yield return new WaitForSeconds(Speed);

        if(globalData.GameOverFlag == true)
        {
            yield break;
        }
        
        }
    }
}
