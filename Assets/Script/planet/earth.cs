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

    }

    void FixedUpdate()
    {
        planet_Move(380.0f);
        earthDistansCount();
    }

}
