using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : AnimetionControler
{
    [SerializeField] GlobalData globalData;

    [SerializeField] GameObject[] GameUIArrey;//0がゲームオーバー1がゲームクリア
    [SerializeField] GameObject   GameLife;
    [SerializeField] Sprite[]     GameLifeArrey;
 


    int HitCount;
    SpriteRenderer  LifeSpriterend;

    void Start()
    {
        globalData.GameClearFlag = false;
        globalData.GameOverFlag  = false;
        LifeSpriterend           = GameLife.GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "meteorite")
        {
            Debug.Log("隕石に当たったよ");
            if( globalData.GameClearFlag == false)
            {
                //隕石に衝突したら
                LifeSpriterend.sprite = GameLifeArrey[HitCount];
                HitCount += 1;
            }

            if(HitCount == 3 && globalData.GameClearFlag == false)
            {
                //ゲームオーバーになったら
                GameUIArrey[0].SetActive(true);
                GameOverAnimetionPlaye();
                globalData.GameOverFlag = true;
            }
        }
        if(collision.gameObject.tag == "eatrth")
        {
            //ゲームクリアになったら
            Debug.Log("地球に当たったよ");
            GameUIArrey[1].SetActive(true);
            GameClearAnimetionPlaye();
            globalData.GameClearFlag = true;
        }
    }

}
