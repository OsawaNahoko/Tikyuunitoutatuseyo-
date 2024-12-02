using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject CreiaObject;
    public GameObject[] GameLifeArrey;

    void Start()
    {
         StartCoroutine("Inseki_Genret");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "meteorite")
        {
            Debug.Log("隕石に当たったよ");
            GameLifeArrey[0].SetActive(true);
        }
        if(collision.gameObject.tag == "eatrth")
        {
            Debug.Log("地球に当たったよ");
            CreiaObject.SetActive(true);
        }
    }

    IEnumerator Inseki_Genret()
    {
         yield return new WaitForSeconds(0.1f);
    }

}
