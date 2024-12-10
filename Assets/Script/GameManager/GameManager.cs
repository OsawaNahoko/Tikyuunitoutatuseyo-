using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Soundplayer
{
    [SerializeField] GlobalData globalData;

    [SerializeField] GameObject   GameLife;
    [SerializeField] Sprite[]     GameLifeArrey;
    [SerializeField] GameObject[] GameUIArrey;
    //０がゲームオーバー１がゲームクリア
    //０がフェードイン　１フェードアウト
    int HitCount;
    SpriteRenderer  LifeSpriterend;

    //ひとつ前のシーン名
	string beforeScene = "";

    Scene prevScene;
    Scene nextScene;
    
    public void FadeIN()
    {
        PlayFadeIN();
    }
    
    public void FadeOUT()
    {
        PlayFadeOUT();
    }

    void Start()
    {
        globalData.GameClearFlag = false;
        globalData.GameOverFlag  = false;
        LifeSpriterend           = GameLife.GetComponent<SpriteRenderer>();
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }

    void OnActiveSceneChanged( Scene prevScene, Scene nextScene )
    {
        if(beforeScene == "1_1_Game" && nextScene.name == "1_1_Game")
        { 
            PlayTriggerAnime(0);
        }
        else
        {
            PlayTriggerAnime(1);
        }
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
                PlaySound(0);
            }
            if(HitCount == 3 && globalData.GameClearFlag == false)
            {
                //ゲームオーバーになったら
                GameUIArrey[0].SetActive(true);
                PlaySound(1);
                PlayBoolAnime(0);
                globalData.GameOverFlag = true;
            }
        }
        
        if(collision.gameObject.tag == "eatrth")
        {
            //ゲームクリアになったら
            Debug.Log("地球に当たったよ");
            GameUIArrey[1].SetActive(true);
            PlayBoolAnime(1);
            globalData.GameClearFlag = true;
        }
    }

}
