using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth : earth_Distans
{
    float ScaleLimit;

    void Start()
    {
        //earthDistansの値を代入
        ScaleLimit = Distansfloat();

        //Base_planetから呼び出しています。
        StartCoroutine(EarthCount());
        ComponentSet();

        Debug.Log("earthのStart");
    }

    void FixedUpdate()
    {
        Earth_Move(ScaleLimit);
        earthDistansCount();
    }

}
