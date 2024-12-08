using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_planet : MonoBehaviour
{
    decimal Scaledecimal;
    float Scalefloat;

    [SerializeField] protected GlobalData globalData;
    
    protected IEnumerator planet_Move(int planetScale,float WaitTime,decimal AddScale)
    {
        //自身のコライダーとスプライトレンダーを取得。
        var thiscol2D       = this.gameObject.GetComponent<BoxCollider2D>();
        var thisSpliteRend  = this.gameObject.GetComponent<SpriteRenderer>();
        

        //隕石を徐々に大きくしてます。
        for(int i = 0; i < planetScale; i++)
        {
            //decimalの値を代入
            Scaledecimal += AddScale;
            Scalefloat = (float)Scaledecimal;

            this.transform.localScale = new Vector3(Scalefloat,Scalefloat,Scalefloat);
            yield return new WaitForSeconds(WaitTime);

            if(globalData.GameOverFlag == true)
            {
                yield break;
            }
        }

        if(Scalefloat >= planetScale * 0.01)
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
