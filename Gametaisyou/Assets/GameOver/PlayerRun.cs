using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour {

	// Use this for initialization
	void Start () {
		                                                        //犬の当たり判定チェック用に作ったコード（テスト用だから消していいヨ！
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Translate(-3, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Translate(3, 0, 0);
        }
	}
}
