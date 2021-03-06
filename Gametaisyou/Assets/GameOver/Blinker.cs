﻿

using UnityEngine;
using System.Collections;
using UnityEngine.UI;


// オブジェクトを点滅させる
public class Blinker : MonoBehaviour
{
    public int ButtonChengeFlg = 0;
    private GameObject ButtonChenge;
    private AudioSource UpDownSound;    //上下移動時の音だじぇ
    // Alpha増減値(点滅スピード調整)
    private float _Step = 0.02f;

    void Start()
    {
        UpDownSound = GetComponent<AudioSource>();
       
       if ( ButtonChengeFlg == 0)  this.ButtonChenge = GameObject.Find("TitleButton");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            UpDownSound.PlayOneShot(UpDownSound.clip);
            Debug.Log("移動音ならすじぇ");
            this.ButtonChenge.GetComponent<Image>().color = new Color(255, 255, 255, 1);
            this.ButtonChenge = GameObject.Find("TitleButton");
            ButtonChengeFlg = 0;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            UpDownSound.PlayOneShot(UpDownSound.clip);
            Debug.Log("移動音ならすじぇ");
            this.ButtonChenge.GetComponent<Image>().color = new Color(255, 255, 255, 1);
            this.ButtonChenge = GameObject.Find("RetryButton");
            ButtonChengeFlg = 1;
        }


        // 現在のAlpha値を取得
        float toColor = this.ButtonChenge.GetComponent<Image>().color.a;
        // Alphaが0 または 1になったら増減値を反転
        if (toColor < 0 || toColor > 1)
        {
            _Step = _Step * -1;
        }
        // Alpha値を増減させてセット
        this.ButtonChenge.GetComponent<Image>().color = new Color(255, 255, 255, toColor + _Step);
    }
}
