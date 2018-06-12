using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    // Use this for initialization
    GameObject ButtonFlgs;
    int Flgs;
    int SpaceBottonFlg; //スペース押されてるか見る人だじぇ
    float TimesCounter; //時間を計測るじぇ
    private AudioSource SelectSound;
    void Start()
    {
        SelectSound = GetComponent<AudioSource>();
        SpaceBottonFlg = 0;
        TimesCounter = 0;

    }

    // Update is called once per frame
    void Update()
    {
        ButtonFlgs = GameObject.Find("ButtonChengeFlgs");
        Flgs = ButtonFlgs.GetComponent<Blinker>().ButtonChengeFlg;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SpaceBottonFlg == 0)
            {
                SpaceBottonFlg = 1;
            }
        }
        if(SpaceBottonFlg == 1)
        {
            SelectSound.PlayOneShot(SelectSound.clip);
            SpaceBottonFlg = 2;
        }
        if(SpaceBottonFlg == 2)
        {
            TimesCounter += Time.deltaTime;
        }
        if (SpaceBottonFlg == 2 && Flgs == 0 && TimesCounter >= 1)
        {

            Debug.Log("ゲームタイトルに移動するで！");
            SceneManager.LoadScene("GameTitle");//シーン切り替え
        }
        if (SpaceBottonFlg == 2 && Flgs == 1 && TimesCounter >= 1)
        {
     
            Debug.Log("retryするで！");
            SceneManager.LoadScene("Gamemain");//ここのシーンの名前をゲームメインに変えてください
        }
    }
}
