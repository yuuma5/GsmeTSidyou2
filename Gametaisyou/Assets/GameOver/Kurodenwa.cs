using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kurodenwa : MonoBehaviour {
    public float CheckTime; //時間計測用変数
    public float UPTime;    //時間加算変数
    public int CheckFlg;    //黒電話の処理がもうすでに起動してるかを確認するフラグ
	// Use this for initialization
	void Start () {
        CheckTime = 1;
        UPTime = 0;
        CheckFlg = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.D)&& CheckFlg == 0)         //ゲットキーダウンのところをother.tagに変えて、if文の外側をOntrggerStay 2Dで当たり判定を取ってほしい。
        {
            CheckFlg = 1;
        }
        if(CheckFlg == 1)
        {
            UPTime += Time.deltaTime;
            if (UPTime >= CheckTime)    //１秒毎に処理をする
            {

                GameObject.Find("Face").GetComponent<Face>().FaceGauge += 10;   //顔ゲージに数値を加算
                UPTime = 0.0f;
            }
        }

	}
}
