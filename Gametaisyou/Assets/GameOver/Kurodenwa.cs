using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kurodenwa : MonoBehaviour {
    public float CheckTime;
    public float UPTime;
    public int CheckFlg;
	// Use this for initialization
	void Start () {
        CheckTime = 1;
        UPTime = 0;
        CheckFlg = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.D)&& CheckFlg == 0)
        {
            CheckFlg = 1;
        }
        if(CheckFlg == 1)
        {
            UPTime += Time.deltaTime;
            if (UPTime >= CheckTime)
            {

                GameObject.Find("Face").GetComponent<Face>().FaceGauge += 10;
                UPTime = 0.0f;
            }
        }

	}
}
