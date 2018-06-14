using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // 変数の定義
    private Transform target;

    // シーン開始時に一度だけ呼ばれる関数
    void Start()
    {
        // 変数にPlayerオブジェクトのtransformコンポーネントを代入
        target = GameObject.Find("hako_0").transform;
    }

    // シーン中にフレーム毎に呼ばれる関数
    void Update()
    {
        // カメラのx座標をPlayerオブジェクトのx座標から取得y座標とz座標は現在の状態を維持
        transform.position = new Vector3(target.position.x+8, transform.position.y, transform.position.z);
       if(transform.position.x < 0){
           transform.position = new Vector3(0, transform.position.y, -0);
        }

        if(transform.position.x >= 69){
            transform.position = new Vector3(69, transform.position.y, -10);
        }
    }
}
