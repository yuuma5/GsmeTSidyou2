using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orgel : MonoBehaviour {
    public float OrgelTime;         //オルゴールの経過時間を加算する変数
    public int OrgelLimitTime;      //６秒経ったか確認するための変数
    public int OrgelOutTime;        //オルゴールのタイムがタイムリミットになったか確認する処理
    public int OrgelFlg;            //オルゴールの処理がもうすでに開始されているか確認するフラグ
    // Use this for initialization
    void Start () {
        OrgelTime = 0;
        OrgelFlg = 0;
        OrgelLimitTime = 6;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.S) && OrgelFlg == 0)       //オルゴールのフラグが立っているか確認する。ゲットキーダウンのところをother.tagに変えて、if文の外側をOntrggerStay 2Dで当たり判定を取ってほしい。
        {
            OrgelFlg = 1;
        }
        if (OrgelFlg == 1)
        {
            OrgelTime += Time.deltaTime;        //時間加算
            if (OrgelTime >= OrgelLimitTime)
            {
               GameObject.Find("Face").GetComponent<Face>().FaceGauge -= 2;     //顔ゲージ減算
                Debug.Log("入った！");
                OrgelOutTime += 6;
                OrgelTime = 0.0f;
            }
            if (OrgelOutTime >= 30)             //オルゴールの時間が制限時間いっぱいになったら終了する
            {
                OrgelOutTime = 0;
                OrgelFlg = 0;
            }

        }

    }
}
