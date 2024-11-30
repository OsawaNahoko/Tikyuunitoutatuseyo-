using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandoleMove : MonoBehaviour
{
    [SerializeField] GameObject Backgraund;
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
            float Loss90RotationZ = HandoleRotationZ - 90;
            BackVec3   = Backgraund.transform.position;
            if(HandoleRotationZ >= 0)
            {
                 BackVec3.x = Loss90RotationZ / 20f;
            }
            else if(HandoleRotationZ <= 0)
            {
                 BackVec3.x = Loss90RotationZ  / 20f;
            }


            Backgraund.transform.position = BackVec3;
    }
}
