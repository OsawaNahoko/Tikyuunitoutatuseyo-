using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandoleMove : MonoBehaviour
{
    [SerializeField] GameObject Backgraund;
    [SerializeField] GameObject earth;

    Vector3 earthVec3;
    Vector3 BackVec3;
    Rigidbody2D rb;
    float HandoleRotationZ;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HandoleRotationZ = rb.rotation;
        Move();
    }

    void Move()
    {
        if(earth != null && Backgraund != null)
        {
            float Loss90RotationZ = HandoleRotationZ - 90;

            //ObjectのポジションをVec3に変換しています。
            BackVec3   = Backgraund.transform.position;
            earthVec3  = earth.transform.position;

            if(HandoleRotationZ >= 0 || HandoleRotationZ <= 0)
            {
                 BackVec3.x  = Loss90RotationZ / 15f;
                 earthVec3.x = Loss90RotationZ / 30f;
            }

            //Objectに計算結果を代入しています。
            Backgraund.transform.position = BackVec3;
            earth.transform.position      = earthVec3;
        }

    }
}
