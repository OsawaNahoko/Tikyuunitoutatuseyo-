using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_planet : MonoBehaviour
{
    float Scale;
    
    protected IEnumerator Inseki_Move(int Time)
    {
        //隕石を徐々に大きくしてます。
        for(int i = 0; i < Time; i++)
        {
            Scale += 0.1f;
            this.transform.localScale = new Vector3(Scale,Scale,Scale);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
