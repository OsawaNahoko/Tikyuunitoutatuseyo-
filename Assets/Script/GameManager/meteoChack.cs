using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoChack : AnimetionControler
{
    [SerializeField] GlobalData globalData;

    [SerializeField] Transform  BackimagePalent;
    [SerializeField] GameObject[] meteoObjArryey;
    [SerializeField] Transform[] meteoposArrey;

    Vector2 meteoposV2;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        var meteoColl = collision.gameObject.GetComponent<BoxCollider2D>();
        var meteoAnime= collision.gameObject.GetComponent<Animator>();

        if(meteoAnime != null)
        { 
            meteoAnime.SetBool("MeteoDestroyFlag",true);
        }

        meteoColl.enabled = false;

        //meteoposV2にインスペクターで設定したランダムな位置を設定する。
        meteoposV2 = meteoposArrey[Random.Range(0,meteoposArrey.Length)].position;
        //隕石を生成する。
        Instantiate(
        meteoObjArryey[Random.Range(0,meteoObjArryey.Length)],//オブジェクトをランダムに選択
        meteoposV2,         //位置
        Quaternion.identity,//回転軸
        BackimagePalent     //親にするオブジェクトを指定
        );
    }

}
