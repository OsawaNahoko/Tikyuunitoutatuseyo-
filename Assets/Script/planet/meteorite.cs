using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorite : Base_planet
{
    void OnEnable()
    {
        StartCoroutine(Inseki_Move(50,0.1f));
    }
}
