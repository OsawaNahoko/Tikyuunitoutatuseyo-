using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class earth_Distans : Base_planet
{
    [SerializeField] Text earthDistansText;
    decimal Distans = 100.0m;

    protected IEnumerator earthDistansCount(int Time,float Speed)
    {
        for(int i = 0; i < Time; i++)
        {

        earthDistansText.text  = $"{Distans}Km";
        Distans -= 0.1m;
        Debug.Log($"動いてる？？{Distans}");
        yield return new WaitForSeconds(Speed);

        if(globalData.GameOverFlag == true)
        {
            yield break;
        }
        }
    }
}
