using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandoleMove : MonoBehaviour
{
    [SerializeField] GameObject Backgraund;
    Vector3 MyVec3;
    Vector3 BackVec3;
    Rigidbody2D rb;
    float rotationZ;

    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rotationZ = rb.rotation;

        if(rotationZ >= 91)
        {
            Move();
            Debug.Log("９０より大きいよ");
        }
        else if(rotationZ <= 89)
        {
            Move();
            Debug.Log("９０より小さいよ");     
        }
    }

    void Move()
    {
            BackVec3   = Backgraund.transform.position;
            BackVec3.x = rotationZ % 2;
            if(rotationZ >= 8.5f)
            {
                BackVec3.x = 8.5f;
            }
            if(rotationZ <= -8.5f)
            {
                BackVec3.x = -8.5f;
            }
            Backgraund.transform.position = BackVec3;
    }
}
