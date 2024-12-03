using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_planet : MonoBehaviour
{
    float Scale;
    BoxCollider2D thiscol2D;
    [SerializeField] GlobalData globalData;
    
    protected IEnumerator Inseki_Move(int Time,float Speed)
    {
        //自身のコライダーを取得。
        thiscol2D = GetComponent<BoxCollider2D>();

        //隕石を徐々に大きくしてます。
        for(int i = 0; i < Time; i++)
        {
            this.transform.localScale = new Vector3(Scale,Scale,Scale);
            Scale += 0.01f;
            yield return new WaitForSeconds(Speed);
            
            if(globalData.GameOverFlag == true)
            {
                yield break;
            }
        }
        if(Scale >= Time * 0.01f - 0.01f)
        {
            //sizeが限界に到達したら
            Debug.Log("サイズ限界になったよ");
            thiscol2D.enabled = true;

            yield return new WaitForSeconds(3.0f);
            this.transform.localScale = new Vector3(0,0,0);
            Destroy(this.gameObject);
        }
    }
}
