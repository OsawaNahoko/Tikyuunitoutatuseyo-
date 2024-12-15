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

    protected void Earth_Move(float ScaleLimit)
    { 
        decimal DesiScale = earthScale();
        float Scale = (float)DesiScale;

        this.transform.localScale = new Vector3(Scale,Scale,Scale);

        if( Scale >= ScaleLimit * 0.01 - 0.01)
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

    protected IEnumerator meteo_Move(float ScaleLimit)
    { 
        float Scale = 0.0f;

        for(float i= 0.0f;i < ScaleLimit; i++)
        {
            Scale += 0.01f;
            yield return new WaitForSeconds(0.1f);

            this.transform.localScale = new Vector3(Scale,Scale,Scale);

            Debug.Log("処理通っています。");

            if(globalData.GameOverFlag == true)
            {
                yield break;
            }
        }

        if( Scale >= ScaleLimit *0.01 - 0.01)
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

}
