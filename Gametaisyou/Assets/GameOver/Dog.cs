using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dog : MonoBehaviour {
 //   public int DogFlg;
 //   public int DogIntTimer;
 //   public float DogFloatTimer;
 //   public int DogOutTime;
	//// Use this for initialization
	//void Start () {
 //       DogIntTimer = 0;
 //       DogFloatTimer = 0.0f;
 //       DogOutTime = 10;
 //       DogFlg = 0;
	//}

void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("当たってるで");
            GameObject.Find("Face").GetComponent<Face>().FaceGaugeNumber = 15;      //当たり判定の中に入ったら判定の中にいる間は移動キー押したときに加算される顔ゲージの数値を１５にする
        }
    }
void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("外れたで＝");
            GameObject.Find("Face").GetComponent<Face>().FaceGaugeNumber = 10;      //当たり判定から外れたら判定内で変えた顔ゲージに加算する数値の値を１０にもどす。
        }
 }
    //   // Update is called once per frame
    //   void Update () {
    //       if (Input.GetKeyDown(KeyCode.Z) && DogFlg == 0)
    //       {
    //           DogFlg = 1;
    //       }
    //       if(DogFlg == 1)
    //       {
    //           DogFloatTimer += Time.deltaTime;
    //           DogIntTimer = (int)DogFloatTimer;
    //           GameObject.Find("Face").GetComponent<Face>().FaceGaugeNumber = 15;
    //           if(DogIntTimer >= DogOutTime)
    //           {
    //               GameObject.Find("Face").GetComponent<Face>().FaceGaugeNumber = 10;
    //               DogIntTimer = 0;
    //               DogFloatTimer = 0.0f;
    //               DogFlg = 0;
    //           }
    //       }
    //}
}
