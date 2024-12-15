using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneScript : MonoBehaviour
{ 
    public float WaitTime;


     public void Load_GameScene(BaseEventData data)
    {
        StartCoroutine(GameScene(WaitTime));
    }

        public void Load_GameScene_2(BaseEventData data)
    {
        StartCoroutine(GameScene_2(WaitTime));
    }

       public void Load_TitletScene(BaseEventData data)
    {
        StartCoroutine(TitleScene(WaitTime));
    }

    IEnumerator GameScene(float WaitTime)
    {
        Debug.Log("Gameをロード");
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene("1_1_Game");
    }

        IEnumerator GameScene_2(float WaitTime)
    {
        Debug.Log("Game_2をロード");
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene("1_2_Game");
    }

        IEnumerator TitleScene(float WaitTime)
    {
        Debug.Log("Titleをロード");
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene("0_1_Title");
    }

    public void Quit(BaseEventData data)
    {
        Application.Quit();
    }

  
}
