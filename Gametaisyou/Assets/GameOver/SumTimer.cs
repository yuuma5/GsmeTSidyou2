using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumTimer : MonoBehaviour {
    float Timer;
	// Use this for initialization
	void Start () {
        Timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Timer += Time.deltaTime;                                //秒ごとの座標を指定
        transform.rotation = Quaternion.Euler(0, 0, -Timer);    //画像の角度を指定した座標に変更
    }
}
