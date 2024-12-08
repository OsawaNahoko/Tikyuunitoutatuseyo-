using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorite : Base_planet
{
    void Start()
    {
        StartCoroutine(planet_Move(50,0.1m));
    }
}
