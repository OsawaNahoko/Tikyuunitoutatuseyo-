using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth : earth_Distans
{
    [SerializeField]int earthTime;
    [SerializeField]float earthSpeed;

    void Start()
    {
        StartCoroutine(planet_Move(earthTime,earthSpeed));
        StartCoroutine(earthDistansCount(earthTime * 10,earthSpeed * 0.1f));
    }
}
