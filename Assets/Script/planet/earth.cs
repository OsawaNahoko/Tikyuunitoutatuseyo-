using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth : Base_planet
{
    void Start()
    {
        StartCoroutine(Inseki_Move(100,1.0f));
    }
}
