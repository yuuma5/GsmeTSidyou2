using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumTimer : MonoBehaviour {
    float Timer;                       //時計の秒針
	// Use this for initialization
	void Start () {
        Timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Timer += Time.deltaTime;                                //秒ごとの座標を指定
        transform.rotation = Quaternion.Euler(0, 0, -Timer);    //画像の角度を指定した座標に変更
        if(Timer >= 180)
        {
            Timer = 180;        //タイマーが１８０秒（ゲーム終了時間）になったら、それ以上先に進まないようにする
            //←
            //このコメント文の箇所にシーンを飛ばす処理を書く！
        }
    }
}
