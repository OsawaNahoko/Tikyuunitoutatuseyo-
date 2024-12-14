using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth : earth_Distans
{
    // [SerializeField]int earthScale;
    // [SerializeField]float earthWaitTime;
    // decimal earthSpeed = 0.01m;

    void Start()
    {
        //Base_planetから呼び出しています。
        StartCoroutine(TimeCount());
        ComponentSet();

        //eath_Distansから呼び出しています。
        // StartCoroutine(earthDistansCount(earthScale,earthWaitTime));
    }

    void FixedUpdate()
    {
        planet_Move(30.0f);
    }

}
