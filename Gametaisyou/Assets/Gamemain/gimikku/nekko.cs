using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nekko : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("しょうがないにゃぁ");
            //行動範囲を制限してその内部でｂジャンプすると飛びついてくる
        }
    }
}
