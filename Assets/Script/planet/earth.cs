using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth : earth_Distans
{
    [SerializeField]int earthScale;
    [SerializeField]float earthWaitTime;
    decimal earthSpeed = 0.01m;

    void Start()
    {
        StartCoroutine(planet_Move(earthScale,earthWaitTime,earthSpeed));
        StartCoroutine(earthDistansCount(earthScale * 10,earthWaitTime * 0.1f));
    }
}
