using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SEplayer
{
    [SerializeField] GlobalData globalData;

    [SerializeField] GameObject   GameLife;
    [SerializeField] GameObject   FadeObject;
    [SerializeField] Sprite[]     GameLifeArrey;
    [SerializeField] GameObject[] GameUIArrey;

    //０がゲームオーバー１がゲームクリア
    //０がフェードイン　１フェードアウト
    public static bool GameSeneFlag;
    int HitCount;
    SpriteRenderer  LifeSpriterend;
    SpriteRenderer  FadeSpriterend;
    
    public void FadeIN()
    {
        PlayFadeIN();
    }
    
    public void FadeOUT()
    {
        PlayFadeOUT();
    }

    void Awake()
    {
         if(GameSeneFlag == true)
        {
            FadeSpriterend.color = new (0,0,0,255);
        }
    }

    void Start()
    {
        globalData.GameClearFlag = false;
        globalData.GameOverFlag  = false;
        LifeSpriterend           = GameLife.GetComponent<SpriteRenderer>();
        FadeSpriterend           = FadeObject.GetComponent<SpriteRenderer>();
        OnActiveSceneChanged();
    }

    void OnActiveSceneChanged()
    {
        if(GameSeneFlag == true)
        { 
            PlayFadeIN();
            Debug.Log(GameSeneFlag);
        }
  else if(GameSeneFlag == false)
        {
            GameSeneFlag = true;
            Debug.Log(GameSeneFlag);
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
