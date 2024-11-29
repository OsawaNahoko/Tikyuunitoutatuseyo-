using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandoleMove : MonoBehaviour
{
    [SerializeField] GameObject Backgraund;
    Vector3 MyVec3;
    Vector3 BackVec3;
    Rigidbody2D rb;

    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float rotationZ = rb.rotation;

        if(rotationZ >= 91)
        {
            BackVec3   = Backgraund.transform.position;
            BackVec3.x = -8.5f;
            Backgraund.transform.position = BackVec3;
            Debug.Log("９０より大きいよ");
        }
        else if(rotationZ <= 89)
        {
            BackVec3   = Backgraund.transform.position;
            BackVec3.x = 8.5f;
            Backgraund.transform.position = BackVec3;
            Debug.Log("９０より小さいよ");     
        }
    }
}
