using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoChack : MonoBehaviour
{
    [SerializeField] GlobalData globalData;

    void Start()
    {
        globalData.meteoriteEndFlag = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        globalData.meteoriteEndFlag = true;
        var CollCorisyion = collision.gameObject.GetComponent<BoxCollider2D>();
        CollCorisyion.enabled = false;
    }

}
