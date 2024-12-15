using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth : earth_Distans
{
    float earthCount;
    float Scale;

    void Start()
    {
        //earthDistansの値を代入
        earthCount = Distansfloat();

        decimal DesiScale = earthScale();
        Scale = (float)DesiScale;

        //Base_planetから呼び出しています。
        StartCoroutine(EarthCount());
        ComponentSet();
    }

    void FixedUpdate()
    {
        Earth_Move(earthCount);
        earthDistansCount();
        Debug.Log("FixedUpdateを呼んでいます");
    }

}
