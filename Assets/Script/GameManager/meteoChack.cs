using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoChack : MonoBehaviour
{
    [SerializeField] GlobalData globalData;

    [SerializeField] Transform  BackimagePalent;
    [SerializeField] GameObject[] meteoObjArryey;
    [SerializeField] Transform[] meteoposArrey;

    Vector2 meteoposV2;

    void Start()
    {
        globalData.meteoriteEndFlag = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        globalData.meteoriteEndFlag = true;
        var CollCorisyion = collision.gameObject.GetComponent<BoxCollider2D>();
        CollCorisyion.enabled = false;
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
