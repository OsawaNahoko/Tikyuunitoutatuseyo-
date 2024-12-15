using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class earth_Distans : Base_planet
{
    [SerializeField] Text earthDistansText;

    protected void earthDistansCount()
    {
        decimal Distansdecimal = earthDistans();
        float DistansFloat =(float)Distansdecimal;

        if(DistansFloat <= 0.0f)
        {
            earthDistansText.text  = $"{0.0f:F2}Km";
        }

        earthDistansText.text  = $"{DistansFloat:F2}Km";
    }
}
