using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Face : MonoBehaviour {
    public Sprite BlueFace;         //通常の顔
    public Sprite YellowFace;       //顔ゲージのゲージの数値が怪しくなってきたら表示する顔をいれる
    public Sprite RedFace;          //顔ゲージが危険なレベルになったときに表示する顔をいれる
    public Sprite BlackFace;        //ゲームオーバー時に表示する顔を入れる
    public int  FaceGauge;          //顔ゲージ（大事）
    public int FaceGaugeNumber;     //顔ゲージに加算する数値を設定する変数
  
	// Use this for initialization
	void Start () {
        FaceGaugeNumber = 10;
	}
	
	// Update is called once per frame
	void Update () {
        if(FaceGauge < 0)       //顔ゲージの下限設定
        {
            FaceGauge = 0;
        }
        if(FaceGauge > 100)     //顔ゲージの上限値設置
        {
            FaceGauge = 100;
        }
        if (Input.GetKeyDown(KeyCode.A))    //Aキーを押したら顔ゲージの数値が上昇する（Aじゃなくてもいいヨ！
        {
            FaceGauge += FaceGaugeNumber;
        }
        if (Input.GetKeyDown(KeyCode.Space))    //スペースキーを押したら顔ゲージが減る
        {
            FaceGauge -= 5;
        }
        if(FaceGauge == 0)                                                 //顔ゲージ変更処理↓
        {
            this.gameObject.GetComponent<Image>().sprite = BlueFace;
        }
        if (70>= FaceGauge&& FaceGauge > 30)
        {
            this.gameObject.GetComponent<Image>().sprite = YellowFace;
        }
        if (100 >FaceGauge && FaceGauge > 70)
        {
            this.gameObject.GetComponent<Image>().sprite = RedFace;
        }
        if (FaceGauge == 100)
        {
            this.gameObject.GetComponent<Image>().sprite = BlackFace;
        }                                                                   //↑ここまで
        Debug.Log(FaceGauge);
       
      //  Debug.Log(OrgelFlg);
	}
}
