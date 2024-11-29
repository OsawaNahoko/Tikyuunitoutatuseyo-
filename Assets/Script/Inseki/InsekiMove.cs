using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsekiMove : MonoBehaviour
{

    void Start()
    {      
        StartCoroutine("Inseki_Move");
    }

    IEnumerator Inseki_Move()
    {
        //隕石を徐々に大きくしてます。
        for(int i = 0; i < 5; i++)
        {
            this.transform.localScale = new Vector3(i,i,i);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
