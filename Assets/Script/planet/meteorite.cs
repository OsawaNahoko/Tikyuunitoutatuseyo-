using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorite : Base_planet
{
    [SerializeField]float meteoscale;

    void Start()
    {
        //Base_planetから呼び出しています。
        ComponentSet();
        StartCoroutine(meteo_Move(meteoscale));
    }
}
