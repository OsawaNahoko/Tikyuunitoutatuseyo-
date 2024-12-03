using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GlobalData globalData;

    [SerializeField] Transform  BackimagePalent;
    [SerializeField]  Transform[] meteoposArrey;

    [SerializeField] GameObject[] GameUIArrey;//0がゲームオーバー1がゲームクリア
    [SerializeField] GameObject[] GameLifeArrey;
    [SerializeField] GameObject[] meteoObjArryey;

    Vector2 meteoposV2;
    int HitCount;

    void Start()
    {
        globalData.GameClearFlag = false;
        globalData.GameOverFlag  = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "meteorite")
        {
            Debug.Log("隕石に当たったよ");
            if(HitCount <= GameLifeArrey.Length - 1)
            {
                GameLifeArrey[HitCount].SetActive(true);
                HitCount += 1;
            }

            if(HitCount == 3 && globalData.GameClearFlag ==false)
            {
                GameUIArrey[0].SetActive(true);
                globalData.GameOverFlag = true;
            }
        }
        if(collision.gameObject.tag == "eatrth")
        {
            Debug.Log("地球に当たったよ");
            GameUIArrey[1].SetActive(true);
            globalData.GameClearFlag = true;
        }
    }

    void Update()
    {
        if(globalData.meteoriteEndFlag == true )
        {
            meteoposV2 = meteoposArrey[Random.Range(0,meteoposArrey.Length)].position;

            Debug.Log("隕石をランダムに生成するよ");

            Instantiate(
            meteoObjArryey[Random.Range(0,meteoObjArryey.Length)],//オブジェクトを選択
            meteoposV2,//位置
            Quaternion.identity,//回転軸
            BackimagePalent//親にするオブジェクトを指定
            );
            globalData.meteoriteEndFlag = false;
        }
    }

}
