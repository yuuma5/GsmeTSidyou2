using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    // Use this for initialization
    GameObject ButtonFlgs;
    int Flgs;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ButtonFlgs = GameObject.Find("ButtonChengeFlgs");
        Flgs = ButtonFlgs.GetComponent<Blinker>().ButtonChengeFlg;
        if (Input.GetKeyDown(KeyCode.Space) && Flgs == 0)
        {
            Debug.Log("ゲームタイトルに移動するで！");
            SceneManager.LoadScene("GameTitle");//シーン切り替え
        }
        if (Input.GetKeyDown(KeyCode.Space) && Flgs == 1)
        {
            Debug.Log("retryするで！");
            SceneManager.LoadScene("GameTitle");//ここのシーンの名前をゲームメインに変えてください
        }
    }
}
