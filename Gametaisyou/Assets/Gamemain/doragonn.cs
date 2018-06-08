using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doragonn : MonoBehaviour
{
    Rigidbody2D rb;
    public bool korosudeflg;
    public float doragonnTime;         //オルゴールの経過時間を加算する変数
    public int doragonnLimitTime;      //６秒経ったか確認するための変数
    public int doragonnOutTime;        //オルゴールのタイムがタイムリミットになったか確認する処理
    public int doragonnFlg;            //オルゴールの処理がもうすでに開始されているか確認するフラグ
    // Use this for initialization
    // Use this for initialization
    void Start()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f, 0.0f));
        rb = GetComponent<Rigidbody2D>();
        doragonnTime = 0;
        doragonnFlg = 1;
        doragonnLimitTime = 180;
        korosudeflg = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (doragonnFlg == 1)
        {
            doragonnTime += Time.deltaTime;        //時間加算
            if (doragonnTime >= doragonnLimitTime)
            {
                //GameObject.Find("Face").GetComponent<Face>().FaceGauge -= 2;     //顔ゲージ減算
                Debug.Log("入った！");
                doragonnOutTime += 180;
                doragonnTime = 0.0f;
                korosudeflg = true;
            }
            if (korosudeflg == true)
            {
                var v = new Vector2(0.6f, rb.velocity.x);
                transform.Translate(v);
            }
        }
    }
}