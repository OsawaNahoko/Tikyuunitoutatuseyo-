using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_planet : Timer
{
    BoxCollider2D thiscol2D;

    protected void ComponentSet()
    {
        //自身のコライダーを取得。
        thiscol2D  = this.gameObject.GetComponent<BoxCollider2D>();
    }

    protected void planet_Move(float ScaleLimit)
    { 
        decimal DesiScale = ScaleCount();
        float Scale = (float)DesiScale;

        this.transform.localScale = new Vector3(Scale,Scale,Scale);
        if( Scale >= ScaleLimit)
        {
            //sizeが限界に到達したら
            Debug.Log("サイズ限界になったよ");
            if(this.thiscol2D != null)
            {
                thiscol2D.enabled = true;
            }
            else
            {
                Debug.LogError("Colliderがnullです。");
            }

        }
    }

    //     //隕石を徐々に大きくしてます。
    //     for(int i = 0; i < planetScale; i++)
    //     {
    //         //decimalの値を代入
    //         Scaledecimal += AddScale;
    //         Scalefloat = (float)Scaledecimal;

    //         this.transform.localScale = new Vector3(Scalefloat,Scalefloat,Scalefloat);
    //         yield return new WaitForSeconds(WaitTime);

    //         if(globalData.GameOverFlag == true)
    //         {
    //             yield break;
    //         }
    //     }

    //     if(Scalefloat >= planetScale * 0.01)
    //     {
    //         //sizeが限界に到達したら
    //         Debug.Log("サイズ限界になったよ");
    //         thiscol2D.enabled = true;

    //         yield return new WaitForSeconds(3.0f);
    //         Destroy(this.gameObject);
    //     }
    // }
}
